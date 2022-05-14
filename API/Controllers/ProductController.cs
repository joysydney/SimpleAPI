using ApplicationCore.Commands;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using ApplicationCore.Queries;
using ApplicationCore.Responses;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController: ControllerBase
    { 
        private readonly IRepository<Product> _repository;
        public ProductController(IRepository<Product> repository)
        {
            _repository = repository;
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> GetProductById(int id)
        {
            var item = await _repository.GetById(id);
            var result = new ProductDto
            (
                Name : item.Name,
                Description : item.Description,
                Price : item.Price
            );

            return Ok(result); 
        }

        [HttpPost]
        public async Task<ActionResult> CreateProduct([FromBody] CreateProductRequest request)
        {
            var response = new CreateProductResponse();
            var product = new Product(request.Name, request.Description, request.Price, 
                request.Quantity, request.Image);
            Product createdProduct = await _repository.Add(product);

            ProductDto result = new ProductDto
            (
                Name : createdProduct.Name,
                Description: createdProduct.Description,
                Price: createdProduct.Price
            );
            response.Product = result;
            return Ok(result);
        }
    }
}