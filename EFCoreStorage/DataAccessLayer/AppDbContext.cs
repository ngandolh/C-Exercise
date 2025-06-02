using DataAccessLayer.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class AppDbContext : DbContext
    {
        private readonly Guid _userId;

        private const string ConnectionString =
            @"Data Source=LAPTOP-HP6ERQBA\SQLEXPRESS,1433;Initial Catalog=ManageBook;
             Persist Security Info=True;User ID=sa;Password=12345;TrustServerCertificate=True;";

        public AppDbContext(DbContextOptions<AppDbContext> options,      //#B
            IUserIdService userIdService = null)                           //#C
            : base(options)
        {
            _userId = userIdService?.GetUserId()                           //#D
                       ?? new ReplacementUserIdService().GetUserId();      //#D
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Tags> Tags { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<PriceOffer> PriceOffers { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) //#E
        {
            modelBuilder.Entity<BookAuthor>()
                .HasKey(x => new { x.BookId, x.AuthorId });

            //modelBuilder.Entity<LineItem>()
            //    .HasOne(p => p.ChosenBook)
            //    .WithMany()
            //    .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Book>()                                    //#F
                .HasQueryFilter(p => !p.SoftDeleted);                      //#F

            modelBuilder.Entity<Order>()                                   //#G
                .HasQueryFilter(x => x.CustomerId == _userId);             //#G
        }

    }
}
