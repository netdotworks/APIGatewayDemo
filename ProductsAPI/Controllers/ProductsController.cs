using Microsoft.AspNetCore.Mvc;
using ProductsAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProductsAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    public class ProductsController : Controller
    {
        private readonly IList<Product> _products;

        public ProductsController()
        {
            _products = new List<Product>()
            {
                new Product {Id = 1, Name = "Product1"},
                new Product { Id = 2, Name = "Product2"}
            };
        }

        public IActionResult GetProducts()
        {
            return Json(_products);
        }

        public IActionResult GetProduct([FromQuery]int productId)
        {
            if (productId <= 0)
            {
                return BadRequest();
            }

            var product = _products.FirstOrDefault(w => w.Id == productId);
            if (product == null)
            {
                return NotFound();
            }

            return Json(product);
        }
    }
}