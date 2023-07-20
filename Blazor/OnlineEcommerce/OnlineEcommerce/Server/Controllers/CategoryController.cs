using Microsoft.AspNetCore.Mvc;
using OnlineEcommerce.Server.Services.CategoryServices;

namespace OnlineEcommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        ICategoryService service;
        public CategoryController(ICategoryService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var responce = await service.GetCategories();
            if (responce.Data is null)
                return NotFound();
            else return Ok(responce);
        }
    }
}
