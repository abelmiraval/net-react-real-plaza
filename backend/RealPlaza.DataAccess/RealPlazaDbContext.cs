using System.Collections.Generic;
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
                    new Product { Id = 1, Name = "Televisor SAMSUNG LED 70' Ultra HD / 4K Smart", Price = 1000, Avatar="https://realplaza.vtexassets.com/arquivos/ids/19952643-800-auto?v=637787185990700000&width=800&height=auto&aspect=true", CategoryId = 1},
                  
                    new Product { Id = 2, Name = "Laptop TUF GAMING 8GB RAM 512GB SSD", Avatar="https://realplaza.vtexassets.com/arquivos/ids/29355975-800-auto?v=637926621748600000&width=800&height=auto&aspect=true", Price = 5000, CategoryId = 2},
                  
                    new Product { Id = 3, Name = "Motorola Moto G9 Power RAM 4GB 128GB Azul", Price = 2000, Avatar="https://realplaza.vtexassets.com/arquivos/ids/30749072-800-auto?v=638016157038870000&width=800&height=auto&aspect=true", CategoryId = 3},
                  
                    new Product { Id = 4, Name = "Televisor Sony 4K HDR Processor X1 65", Price = 1000, Avatar ="https://realplaza.vtexassets.com/arquivos/ids/16669049-800-auto?v=637583552723330000&width=800&height=auto&aspect=true", CategoryId = 1},
                  
                    new Product { Id = 5, Name = "Laptop MAC M2 16GB RAM 512GB SSD", Price = 6000, Avatar = "https://realplaza.vtexassets.com/arquivos/ids/18614998-300-auto?v=637769274914830000&width=300&height=auto&aspect=true", CategoryId = 2},
                  
                    new Product { Id = 6, Name = "Impresora Multifuncional Epson L3210 Ecotank", Price = 2000, Avatar="https://realplaza.vtexassets.com/arquivos/ids/17895992-800-auto?v=637741743708070000&width=800&height=auto&aspect=true" ,CategoryId = 3},
                  
                    new Product { Id = 7, Name = "Televisor Samsung Smart TV 65' Crystal UHD 4K", Price = 1000, Avatar="https://realplaza.vtexassets.com/arquivos/ids/30794966-800-auto?v=638019917577870000&width=800&height=auto&aspect=true", CategoryId = 1},
                  
                    new Product { Id = 8, Name = "Netbook LENOVO D330-10IGL 32GB RAM 512GB SSD", Price = 7000, Avatar ="https://realplaza.vtexassets.com/arquivos/ids/17871602-800-auto?v=637738853647470000&width=800&height=auto&aspect=true", CategoryId = 2},
                  
                    new Product { Id = 9, Name = "Parlante bluetooth JBL Party Box 710 potencia 800W RMS", Price = 2000, Avatar="https://realplaza.vtexassets.com/arquivos/ids/29754680-800-auto?v=637953073800630000&width=800&height=auto&aspect=true", CategoryId = 3},
                  
                    new Product { Id = 10, Name = "Apple MacBook Pro con M1 Max Chip", Price = 1000, Avatar = "https://realplaza.vtexassets.com/arquivos/ids/29471812-800-auto?v=637934066359800000&width=800&height=auto&aspect=true", CategoryId = 1}
                });

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}