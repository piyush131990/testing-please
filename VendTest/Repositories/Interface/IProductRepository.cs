using VendTest.Models;

namespace VendTest.Repositories.Interface
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetProducts();
        public Product GetProductById(int id);
        public IEnumerable<Product> AddProduct(Product product);
    }
}
