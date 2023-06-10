using CoreBusiness;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugins.SQL
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Catigories { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(c => c.Products)
                .WithOne(p => p.Category)
                .HasForeignKey(p => p.CategoryId);

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Напитки", Description = "Напитки" },
                new Category { CategoryId = 2, Name = "Закуска", Description = "Закуска" },
                new Category { CategoryId = 3, Name = "Мясо", Description = "Мясо" });

            modelBuilder.Entity<Product>().HasData(
                new Product { CategoryId = 1, Name = "Чай", Price = 100, ProductId = 1, Quantity = 100 },
                 new Product { CategoryId = 3, Name = "стейк", Price = 200, ProductId = 2, Quantity = 100 });
        }
    }
}
