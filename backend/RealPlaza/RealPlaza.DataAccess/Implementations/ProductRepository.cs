using Microsoft.EntityFrameworkCore;
using RealPlaza.DataAccess.Interfaces;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System;
using System.Linq;
using AutoMapper;
using RealPlaza.Entities;
using ProductInfo = RealPlaza.DataAccess.Complex.ProductInfo;

namespace RealPlaza.DataAccess.Implementations
{
    public class ProductRepository : IProductRepository
    {
        private readonly RealPlazaDbContext _context;
        private readonly IMapper _mapper;

        public ProductRepository(RealPlazaDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<(ICollection<ProductInfo> Collection, int Total)> GetCollectionAsync(int page, int rows, string orderBy, decimal price)
        {
            Expression<Func<Product, bool>> expression = p => price > 0 ? p.Price <= price : true;

            var query = _context.Set<Product>()
                .Include(p => p.Category)
                .Where(expression);

            query = orderBy == "DESC" ? query.OrderByDescending(p => p.Price) : query.OrderBy(p => p.Price);

            query = query.Skip((page - 1) * rows)
                .Take(rows);

            var totalCount = await _context.Set<Product>()
                .Where(expression)
                .CountAsync();

            var collection = await query
                .Select(x => _mapper.Map<ProductInfo>(x))
                .ToListAsync();

            return (collection, totalCount);

        }
    }
}