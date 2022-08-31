using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Product.Business.Abstract;
using Product.Entities.Concrete;

namespace Product.HttpApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCategoriesController : ControllerBase
    {
        private IProductCategoryService _productCategoryService;

        public ProductCategoriesController(IProductCategoryService productCategoryService)
        {
            _productCategoryService = productCategoryService;
        }

        [HttpGet("getall")]
        public IActionResult GetList()
        {
            var result = _productCategoryService.GetList();
            return Ok(result);
        }

        [HttpPost("add")]
        public IActionResult Add(ProductCategory category)
        {
            _productCategoryService.Add(category);
            return Ok();
        }

        [HttpPost("update")]
        public IActionResult Update(ProductCategory category)
        {
            _productCategoryService.Update(category);
            return Ok();
        }

        [HttpPost("delete")]
        public IActionResult Delete(ProductCategory category)
        {
            _productCategoryService.Delete(category);
            return Ok();
        }
    }
}
