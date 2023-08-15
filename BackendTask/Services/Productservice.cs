using BackendTask.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackendTask.Services
{
    public class Productservice : IProductInterface
    {
        private readonly ProductContext _context;

        public Productservice(ProductContext context)
        {
            _context = context;
        }

        public async Task<Product> AddProduct(Product product)
        {
            product.createDate= DateTime.Now;
          await  _context.Products.AddAsync(product);
           await _context.SaveChangesAsync();
            return product;
        }

        public void Deleteproduct(int id)
        {
            var deletedproduct= _context.Products.Find(id);
            _context.Products.Remove(deletedproduct);
            _context.SaveChanges();
         }

        public async Task<List<Product>> GetAllProducts()
        {
            var results=await  _context.Products.ToListAsync();
            return results;
        }
    }
}
