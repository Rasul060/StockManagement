using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Product.Business.Abstract;
using Product.Entities.Concrete;

namespace Product.HttpApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("getall")]
        public IActionResult GetList()
        {
            var result = _productService.GetList();
            return Ok(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int productId)
        {
            var result = _productService.GetById(productId);
            return Ok(result);
        }

        [HttpPost("add")]
        public IActionResult Add(ProductItem product)
        {
           _productService.Add(product);
           return Ok();
        }

        [HttpPost("update")]
        public IActionResult Update(ProductItem product)
        {
            _productService.Update(product);
            return Ok();
        }

        [HttpPost("delete")]
        public IActionResult Delete(ProductItem product)
        {
            _productService.Delete(product);
            return Ok();
        }
    }
}
