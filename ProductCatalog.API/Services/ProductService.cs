using ProductCatalog.API.Models;
namespace ProductCatalog.API.Services
{
    public class ProductService : IProductService
    {
        private static readonly List<Product> _products = new()
        {
            new Product { Id = 1, Name = "Keyboard", Price = 1500 },
            new Product { Id = 2, Name = "Mouse", Price = 800 }
        };

        public List<Product> GetAll()
        {
            return _products;
        }

        public Product? GetById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }

        public Product Add(Product product)
        {
            var nextId = _products.Max(p => p.Id) + 1;
            product.Id = nextId;
            _products.Add(product);
            return product;
        }
    }
}
