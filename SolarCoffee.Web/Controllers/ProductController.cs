using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SolarCoffee.Data.Models;
using SolarCoffee.Repository.Models;
using SolarCoffee.Services;

namespace SolarCoffee.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IProductService _productService;
        public ProductController(
            ILogger<ProductController> logger, 
            IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        [HttpGet("products")]
        public async Task<IActionResult> GetProducts([FromQuery] CustomerParameters CustomerParameters)
        {
            var Products = _productService.GetProducts(CustomerParameters);
            
            var metadata = new
            {
                Products.TotalCount,
                Products.PageSize,
                Products.CurrentPage,
                Products.TotalPages,
                Products.HasNext,
                Products.HasPrevious
            };

            Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(metadata));

            _logger.LogInformation($"Returned {Products.TotalCount} Products from database.");

            return Ok(Products.TotalCount);
        }
    }
}