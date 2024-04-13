using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StarShop.ProductApi.DTOs;
using StarShop.ProductApi.Services;

namespace StarShop.ProductApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDTO>>> Get()
        {
            var productDto = await _productService.GetProducts();
            if (productDto is null)
                return NotFound("Product not found");
            return Ok(productDto);
        }

        [HttpGet("{id:int}", Name = "GetProduct")]
        public async Task<ActionResult<ProductDTO>> Get(int id)
        {
            var productDto = await _productService.GetProductById(id);
            if (productDto is null)
            {
                return NotFound("Product not found");
            }
            return Ok(productDto);
        }

        [HttpPost]
        public async Task<ActionResult> Post(ProductDTO productDTO)
        {
            if (productDTO is null)
                return BadRequest("Invalid Data");
            await _productService.AddProduct(productDTO);

            return new CreatedAtRouteResult("GetProduct", new { id = productDTO.Id },
                productDTO);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id, ProductDTO productDTO)
        {
            if (id != productDTO.Id)
                return BadRequest();

            if (productDTO is null)
                return BadRequest();

            await _productService.UpdateProduct(productDTO);

            return Ok(productDTO);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ProductDTO>> Delete(int id)
        {
            var productDto = await _productService.GetProductById(id);
            if (productDto is null)
                return NotFound("Product not found");

            await _productService.RemoveProduct(id);
            return Ok(productDto);
        }
    }
}
