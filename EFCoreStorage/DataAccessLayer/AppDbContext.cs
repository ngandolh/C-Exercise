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
        private const string ConnectionString =
            @"Data Source=LAPTOP-HP6ERQBA\SQLEXPRESS,1433;Initial Catalog=MyFirstEfCoreDb;
             Persist Security Info=True;User ID=sa;Password=12345";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Tags> Tags { get; set; }
        public DbSet<Review> Reviews { get; set; }
    }
}
