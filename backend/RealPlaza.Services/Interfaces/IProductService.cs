using Realplaza.Dto.Response;
using System.Collections.Generic;
using System.Threading.Tasks;
using RealPlaza.DataAccess.Complex;

namespace RealPlaza.Services.Interfaces
{
    public interface IProductService
    {
        Task<BaseCollectionResponse<ICollection<ProductInfo>>> GetAsync(int page, int rows, string orderBy, decimal price);
    }
}