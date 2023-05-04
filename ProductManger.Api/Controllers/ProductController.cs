using Microsoft.AspNetCore.Mvc;
using ProductManager.Domian.Interface;
using ProductMananger.Core.Models;

namespace ProductManger.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService) 
        {
            _productService = productService;
        }

        [HttpGet("(id)")]
        public async Task<ActionResult<Product>> ObterProdutoPorIdAsync(int id)
        {
            var product = await _productService.ObterProdutoPorIdAsync(id); 
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }



    }
}