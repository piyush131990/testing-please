using Microsoft.AspNetCore.Mvc;
using VendTest.Models;
using VendTest.Repositories.Interface;

namespace VendTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _productRepository.GetProducts();
        }

        [HttpGet("/Products/{id}")]
        public Product Get(int id)
        {
            return _productRepository.GetProductById(id);
        }

        [HttpPost]
        public IEnumerable<Product> Post([FromBody]Product product)
        {
            return _productRepository.AddProduct(product);
        }
    }
}