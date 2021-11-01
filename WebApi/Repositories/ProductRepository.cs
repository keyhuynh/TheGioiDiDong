using AppModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Data;

namespace WebApi.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext appDbContext;
        public ProductRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public async Task<Product> AddProduct(Product Product)
        {
            var result = await appDbContext.products.AddAsync(Product);
            await appDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Product> DeleteProduct(int Id)
        {
            var result = await appDbContext.products.FindAsync(Id);
            if (result != null)
            {
                appDbContext.products.Remove(result);
                await appDbContext.SaveChangesAsync();
                return result;
            }
            return null;
        }

        public async Task<List<Product>> GetProducts(string search)
        {
            if (!string.IsNullOrEmpty(search))
            {
                return await appDbContext.products.Where(x => x.Name.ToLower().Contains(search.ToLower())).ToListAsync();
            }
            return await appDbContext.products.ToListAsync();

        }

        public async Task<Product> GetProduct(int Id)
        {
            var Product = await appDbContext.products.FindAsync(Id);
            return Product;
        }

        public async Task<Product> UpdateProduct(Product Product)
        {
            var result = await appDbContext.products.FindAsync(Product.Id);
            if (result != null)
            {
                result.Name = Product.Name;
                result.CategoryId = Product.CategoryId;
                result.Description = Product.Description;
                result.Price = Product.Price;
                result.ThumbnailImage = Product.ThumbnailImage;
                await appDbContext.SaveChangesAsync();
                return result;
            }
            return null;
        }
    }
}
