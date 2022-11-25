using Realplaza.Dto.Response;
using RealPlaza.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using System.Linq;
using RealPlaza.DataAccess.Complex;
using AutoMapper;
using Microsoft.Extensions.Logging;
using RealPlaza.DataAccess.Interfaces;

namespace RealPlaza.Services.Implementations
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;
        private readonly ILogger<ProductService> _logger;

        public ProductService(IProductRepository repository, IMapper mapper, ILogger<ProductService> logger)
        {
            _repository = repository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<BaseCollectionResponse<ICollection<ProductInfo>>> GetAsync(int page, int rows, string orderBy, decimal price)
        {
            var response = new BaseCollectionResponse<ICollection<ProductInfo>>();

            try
            {
                var tuple = await _repository.GetCollectionAsync(page, rows, orderBy, price);
                response.Result = tuple.Collection.ToList();
                response.TotalPages = Utils.Pagination.GetTotalPages(tuple.Total, rows);
                response.Success = true;
            }
            catch (Exception ex)
            {
                _logger.LogCritical(ex.StackTrace);
                response.Success = false;
                response.Errors.Add(Utils.Message.Error);
            }

            return response;
        }
    }
}