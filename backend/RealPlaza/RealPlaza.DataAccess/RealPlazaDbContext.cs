using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using RealPlaza.Entities;
using Microsoft.EntityFrameworkCore;

namespace RealPlaza.DataAccess
{
    public class RealPlazaDbContext : DbContext
    {
        protected RealPlazaDbContext()
        {
        }

        public RealPlazaDbContext(DbContextOptions<RealPlazaDbContext> options)
            : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>()
                .HasQueryFilter(p => p.Status)
                .Property(p => p.Status)
                .HasDefaultValue(true);

            modelBuilder.Entity<Category>()
                .Property(p => p.CreatedAt)
                .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<Product>()
                .HasQueryFilter(p => p.Status)
                .Property(p => p.Status)
                .HasDefaultValue(true);

            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasColumnType("decimal(10,2)");

            modelBuilder.Entity<Product>()
                .Property(p => p.CreatedAt)
                .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<Category>()
                .HasData(new List<Category>
                {
                    new Category { Id = 1, Name = "Televisores", Description = "Televisores"},
                    new Category { Id = 2, Name = "Laptop", Description = "Laptop"},
                    new Category { Id = 3, Name = "Celulares", Description = "Celulares"},
                });

            modelBuilder.Entity<Product>()
                .HasData(new List<Product>
                {
                    new Product { Id = 1, Name = "Televisor LG 1040K HD", Price = 1000, CategoryId = 1},
                    new Product { Id = 2, Name = "Laptop MAC M1", Price = 5000, CategoryId = 2},
                    new Product { Id = 3, Name = "Motorola G9", Price = 2000, CategoryId = 3},
                    new Product { Id = 4, Name = "Televisor Sony 1040K HD", Price = 1000, CategoryId = 1},
                    new Product { Id = 5, Name = "Laptop MAC M2", Price = 6000, CategoryId = 2},
                    new Product { Id = 6, Name = "Motorola G9", Price = 2000, CategoryId = 3},
                    new Product { Id = 7, Name = "Televisor Samsumg 1040K HD", Price = 1000, CategoryId = 1},
                    new Product { Id = 8, Name = "Laptop MAC M1", Price = 7000, CategoryId = 2},
                    new Product { Id = 9, Name = "Motorola G9", Price = 2000, CategoryId = 3},
                    new Product { Id = 10, Name = "Televisor Daweo 1040K HD", Price = 1000, CategoryId = 1}
                });

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}