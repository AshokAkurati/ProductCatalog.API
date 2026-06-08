using ProductCatalog.API.Models;
namespace ProductCatalog.API.Services
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product? GetById(int id);
        Product Add(Product product);
    }
}
