using Entytess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using repository;
using servies;

namespace project.Controllers
{
        [Route("api/[controller]")]
        [ApiController]
    public class ProductController : Controller
    {

        private readonly IProductServices _product;
        public ProductController(IProductServices _Product)
        {
            _product = _Product;
        }

    
  

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Product>>> GetAllProducts()
    {
            IEnumerable<Product> products = await _product.getAllProduct();


            return Ok(products);
    }
        //[HttpPost]
       
        
        //    public async Task<CreatedAtActionResult> CreatNewProduct([FromBody] Product product)
        //{

        //    return await _product.CreatNewProduct(product);
        //    ;
        //}


}


}
