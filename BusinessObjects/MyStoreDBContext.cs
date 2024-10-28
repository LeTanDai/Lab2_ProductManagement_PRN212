using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public partial class MyStoreDBContext : DbContext
    {
        public MyStoreDBContext()
        { }

        public MyStoreDBContext(DbContextOptions<MyStoreDBContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builer = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfigurationRoot configuration = builer.Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("MyStoreDB"));
        }

        public DbSet<Products> Products { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<AccountMember> AccountMember { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>().HasData(
                new Categories { CategoryID = 1, CategoryName = "Beverages" },
                new Categories { CategoryID = 2, CategoryName = "Condiments" },
                new Categories { CategoryID = 3, CategoryName = "Confections" },
                new Categories { CategoryID = 4, CategoryName = "Dairy Products" },
                new Categories { CategoryID = 5, CategoryName = "Grains/Cereals" },
                new Categories { CategoryID = 6, CategoryName = "Meat/Poultry" },
                new Categories { CategoryID = 7, CategoryName = "Produce" },
                new Categories { CategoryID = 8, CategoryName = "Seafood" }

            );

            modelBuilder.Entity<Products>().HasData(
               new Products { ProductId = 1, ProductName = "Chai", CategoryID = 3, UnitsInStock = 12, Price = 18.00m },
               new Products { ProductId = 2, ProductName = "Chang", CategoryID = 1, UnitsInStock = 23, Price = 19.00m },
               new Products { ProductId = 3, ProductName = "Aniseed Syrup", CategoryID = 2, UnitsInStock = 23, Price = 10.00m },
               new Products { ProductId = 4, ProductName = "Chef Anton's Cajun Seasoning", CategoryID = 2, UnitsInStock = 34, Price = 22.00m },
               new Products { ProductId = 5, ProductName = "Chef Anton's Gumbo Mix", CategoryID = 2, UnitsInStock = 45, Price = 21.35m },
               new Products { ProductId = 6, ProductName = "Grandma's Boysenberry Spread", CategoryID = 2, UnitsInStock = 21, Price = 25.00m },
               new Products { ProductId = 7, ProductName = "Uncle Bob's Organic Dried Pears", CategoryID = 7, UnitsInStock = 22, Price = 30.00m },
               new Products { ProductId = 8, ProductName = "Northwoods Cranberry Sauce", CategoryID = 2, UnitsInStock = 10, Price = 40.00m },
               new Products { ProductId = 9, ProductName = "Mishi Kobe Niku", CategoryID = 6, UnitsInStock = 12, Price = 97.00m },
               new Products { ProductId = 10, ProductName = "Ikura", CategoryID = 8, UnitsInStock = 13, Price = 31.00m }
           );

            modelBuilder.Entity<AccountMember>().HasData(
                new AccountMember { MemberID = "PS0001", MemberPassword = "@1", MemberName = "Administrator", EmailAddress = "admin@CompanyName.com", MemberRole = 1 },
                new AccountMember { MemberID = "PS0002", MemberPassword = "@2", MemberName = "Staff", EmailAddress = "staff@CompanyName.com", MemberRole = 2 },
                new AccountMember { MemberID = "PS0003", MemberPassword = "@3", MemberName = "Member 1", EmailAddress = "member1@CompanyName.com", MemberRole = 3 },
                new AccountMember { MemberID = "PS0004", MemberPassword = "@3", MemberName = "Member 2", EmailAddress = "member2@CompanyName.com", MemberRole = 3 }
            );
        }
    }
}