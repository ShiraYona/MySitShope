using Entytess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using servies;

namespace project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        private readonly ICategoryServices _category;
        public CategoryController(ICategoryServices category)
        {
            _category = category;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category>>> GetAllCategory()
        {
            IEnumerable< Category> categories  = await _category.GetAllCategory();


            return Ok(categories);
        }
    }
}
