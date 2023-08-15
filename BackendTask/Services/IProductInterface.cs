using BackendTask.Models;

namespace BackendTask.Services
{
    public interface IProductInterface
    {
        Task<List<Product>> GetAllProducts();
        Task<Product> AddProduct(Product product);
        void Deleteproduct(int id);
    }
}
