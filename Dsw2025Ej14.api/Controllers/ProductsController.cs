using Dsw2025Ej14.api.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Dsw2025Ej14.api.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductsController
    {
        private readonly IPersistencia _persistencia;
        public ProductsController(IPersistencia persistencia)
        {
            _persistencia = persistencia;
        }
        [HttpGet()]
        public IActionResult GetProducts()
        {
            var products = _persistencia.getProducts;
            if (products?.Any() == false) return NoContentResult();
            return Ok(products);
        }
        [HttpGet("{sku}")]
        public IActionResult GetProduct(string sku)
        {
            var product = _persistencia.getProductBySku(sku);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
