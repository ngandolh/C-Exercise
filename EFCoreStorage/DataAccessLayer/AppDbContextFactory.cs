using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer(
                @"Data Source=LAPTOP-HP6ERQBA\SQLEXPRESS,1433;Initial Catalog=ManageBook;
                  Persist Security Info=True;User ID=sa;Password=12345;TrustServerCertificate=True;");

            return new AppDbContext(optionsBuilder.Options);
        }
    }

}
