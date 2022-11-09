using RealPlaza.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Realplaza.Dto.Response;

namespace Realplaza.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        private readonly IProductService _service;

        public ProductsController(IProductService service)
        {
            _service = service;
        }

        [ProducesResponseType(typeof(BaseResponseGeneric<ICollection<ProductResponse>>), 200)]
        public async Task<IActionResult> Get(int page = 1, int rows = 10, string orderBy = "DESC", decimal price = 0)
        {
            return Ok(await _service.GetAsync(page, rows, orderBy, price));
        }
    }
}