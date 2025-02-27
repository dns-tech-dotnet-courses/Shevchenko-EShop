using Microsoft.AspNetCore.Mvc;
using EShop.Application;
using System.Diagnostics;

namespace EShop.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<ProductDto> Get([FromQuery] decimal? priceFilter, [FromQuery] string? priceSortOrder)
        {
            var handler = new ProductHandler();
            var products = handler.Get();

            if (priceFilter is not null)
                products = products.Where(p => p.Price <= priceFilter);

            if (!string.IsNullOrEmpty(priceSortOrder))
            {
                products = priceSortOrder.Equals("desc", StringComparison.OrdinalIgnoreCase)
                    ? products.OrderByDescending(p => p.Price)
                    : products.OrderBy(p => p.Price);
            }

            var productsDto = products.Select(p => new ProductDto(p.Name, p.Price));
            return productsDto;
        }

        [HttpGet("getByName")]
        public IEnumerable<Eshop.Domain.Product> GetByName([FromQuery] string? Name)
        {

            var handler = new ProductHandler();
            var products = handler.Get();

            if (!string.IsNullOrEmpty(Name))
                products = products.Where(p => p.Name == Name);

            return products;
        }

    }
}
