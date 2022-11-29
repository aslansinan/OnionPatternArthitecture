using Microsoft.EntityFrameworkCore;
using OnionPatternDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionPattern.Persistences.Context
{
    public class ApplicationDbContext :DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
                
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product() { id = Guid.NewGuid(), Name = "Pen", Value = 10, Quantity = 100 },
                new Product() { id = Guid.NewGuid(), Name = "PaperA4", Value = 1, Quantity = 200 },
                new Product() { id = Guid.NewGuid(), Name = "Book", Value = 30, Quantity = 500 });
            base.OnModelCreating(modelBuilder);
        }
    }
}
