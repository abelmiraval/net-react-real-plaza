using System.Collections.Generic;
using System.Threading.Tasks;
using RealPlaza.DataAccess.Complex;

namespace RealPlaza.DataAccess.Interfaces
{
    public interface IProductRepository
    {
        Task<(ICollection<ProductInfo> Collection, int Total)> GetCollectionAsync(int page, int rows,
            string orderBy, decimal price);
    }
}