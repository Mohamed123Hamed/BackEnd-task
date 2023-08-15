using BackendTask.Models;
using BackendTask.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackendTask.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductInterface _productinterface;

        public ProductController(IProductInterface productinterface)
        {
            _productinterface = productinterface;
        }

        [HttpGet]                         // GET: /api/Product/GetAllProducts
        public async Task<IActionResult> GetAllProducts()
        {
            return Ok( await _productinterface.GetAllProducts());
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]                         // Post: /api/Product/AddProduct
        public async Task<IActionResult> AddProduct([FromBody] Product product)
        {
           await _productinterface.AddProduct(product);
            return Ok(product);
        }

        [HttpDelete("{id}")]          // DELETE: /api/Product/DeleteProduct
        public void DeleteProduct(int id)
        {
            _productinterface.Deleteproduct(id);
        }
    }
}
