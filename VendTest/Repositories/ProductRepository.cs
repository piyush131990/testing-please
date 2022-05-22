using VendTest.Models;
using VendTest.Repositories.Interface;

namespace VendTest.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> _products;

        public ProductRepository()
        {
            _products = new List<Product>();
            _products.Add(new Product { Id = 1, Name = "Milk", Price = 4.0 });
        }

        public IEnumerable<Product> GetProducts() => _products.ToList();

        public Product GetProductById(int id) => _products.FirstOrDefault(p => p.Id == id);

        public IEnumerable<Product> AddProduct(Product product)
        {
            product.Id = _products.Max(p => p.Id) + 1;
            _products.Add(product);
            return GetProducts();
        }
    }
}
