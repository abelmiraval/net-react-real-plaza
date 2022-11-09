using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Extensions.Logging;
using Moq;
using RealPlaza.DataAccess.Implementations;
using RealPlaza.Services.Implementations;
using RealPlaza.Services.Utils;
using Xunit;

namespace RealPlaza.UnitTest
{
    public class RealPlazaTest : RealPlazaDbContextUnitTest
    {

        [Fact]
        public void PaginationTest()
        {
            // Arrange
            var total = 29;
            var rows = 10;

            // Act
            var resultado = Pagination.GetTotalPages(total, rows);
            var expected = 3;

            // Assert
            Assert.Equal(expected, resultado);
        }

        [Theory]
        [InlineData(29, 10, 3)]
        [InlineData(110, 10, 11)]
        [InlineData(200, 5, 40)]
        public void PagationWithParametersTest(int total, int rows, int expected)
        {
            var resultado = Pagination.GetTotalPages(total, rows);

            Assert.Equal(expected, resultado);
        }

        [Theory]
        [InlineData(10, 10)]
        [InlineData(4, 25)]
        public async Task PaginationForProductsTest(int rows, int expected)
        {
            // Arrange
            var mapper = new Mock<IMapper>();
            var repository = new ProductRepository(Context, mapper.Object);
            var logger = new Mock<ILogger<ProductService>>();

            var service = new ProductService(repository, mapper.Object, logger.Object);

            // Act
            var actual = await service.GetAsync(1, rows, "DESC", 0);

            // Assert

            Assert.Equal(expected, actual.TotalPages);
        }
    }
}
