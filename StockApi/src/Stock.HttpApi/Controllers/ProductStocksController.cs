using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Product.Business.Abstract;
using Stock.Business.Abstract;
using Stock.Entities;

namespace Stock.HttpApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductStocksController : ControllerBase
    {
        private IProductStockService _productStockService;

        public ProductStocksController(IProductStockService productStockService)
        {
            _productStockService = productStockService;
        }

        [HttpGet("getstock")]
        public IActionResult GetStock(int productId)
        {
            var result = _productStockService.GetStock(productId);
            return Ok(result);
        }

        [HttpPost("addstock")]
        public IActionResult AddStock(ProductStock productStock)
        {
           _productStockService.AddStock(productStock);
           return Ok();
        }

        [HttpPost("removestock")]
        public IActionResult RemoveStock(ProductStock productStock)
        {
            _productStockService.RemoveStock(productStock);
            return Ok();
        }
    }
}
