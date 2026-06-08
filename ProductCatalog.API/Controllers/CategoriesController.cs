using Microsoft.AspNetCore.Mvc;
using ProductCatalog.API.Models;

namespace ProductCatalog.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new[]
            {
                new Category { Id = 1, Title = "Electronics" },
                new Category { Id = 2, Title = "Accessories" }
            });
        }
    }
}

