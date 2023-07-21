using Microsoft.AspNetCore.Mvc;
using OnlineEcommerce.Server.Services.ProductServices;
using OnlineEcommerce.Shared;
using System.Xml.Serialization;

namespace OnlineEcommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        IProductService service;
        public ProductController(IProductService productService)
        {
            this.service = productService;
        }
        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            ServiceResponce<ProductsGetResult> responce = await service.GetProducts();
            if (responce.Success)
            {
                return Ok(responce);
            }
            else return NotFound(responce);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            ServiceResponce<Product> responce = await service.GetProduct(id);
            if (responce.Success)
            {
                return Ok(responce);
            }
            else return NotFound(responce);
        }

        [HttpGet]
        [Route("getByCategory/{categoryUrl}")]
        public async Task<IActionResult> GetProductsByCategory(string categoryUrl)
        {
            ServiceResponce<ProductsGetResult> responce = await service.GetProductsByCategory(categoryUrl);
            if (responce.Data is null)
                return NotFound(responce);
            else return Ok(responce);
        }

        [HttpGet]
        [Route("search/{text}")]
        public async Task<IActionResult> GetSearchProducts(string text)
        {
            ServiceResponce<ProductsGetResult> responce = await service.SearchProduct(text);
            if (responce.Success)
            {
                return Ok(responce);
            }
            else return NotFound(responce);
        }

        [HttpGet]
        [Route("search/getSuggestions/{text}")]
        public async Task<IActionResult> GetSearchSuggestions(string text)
        {
            ServiceResponce<List<string>> responce = await service.GetSearchSuggestions(text);
            if (responce.Success)
            {
                return Ok(responce);
            }
            else return NotFound(responce);
        }

        [HttpGet]
        [Route("featured/")]
        public async Task<IActionResult> GetFeaturedProducts()
        {
            ServiceResponce<List<Product>> responce = await service.GetFeaturedProducts();
            if (responce.Success)
            {
                return Ok(responce);
            }
            else return NotFound(responce);
        }
    }
}
