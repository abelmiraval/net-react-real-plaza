using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using RealPlaza.DataAccess;
using RealPlaza.Entities;

namespace RealPlaza.UnitTest
{
    public class RealPlazaDbContextUnitTest : IDisposable
    {
        protected readonly RealPlazaDbContext Context;

        protected RealPlazaDbContextUnitTest()
        {
            var options = new DbContextOptionsBuilder<RealPlazaDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            Context = new RealPlazaDbContext(options);

            Context.Database.EnsureCreated();

            Seed();
        }

        private void Seed()
        {
            var random = new Random();
            var list = new List<Product>();

            for (int i = 0; i < 100; i++)
            {
                var valor = random.Next(20, 400);

                list.Add(new Product()
                {
                    Name = $"Product {valor}",
                    Price = Convert.ToDecimal(random.Next(1000, 9000)),
                    CategoryId = 1,
                    CreatedAt = new DateTime(random.Next(2018, 2022), random.Next(1, 12), random.Next(1, 28)),
                    Status = true,
                });
            }

            Context.Set<Product>().AddRange(list);
            Context.SaveChanges();
        }

        public void Dispose()
        {
            Context?.Dispose();
        }
    }
}