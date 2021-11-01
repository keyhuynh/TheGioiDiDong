using AppModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Repositories
{
    public  interface IProductRepository
    {
        Task<List<Product>> GetProducts(string search);
        Task<Product> GetProduct(int Id);
        Task<Product> AddProduct(Product Product);
        Task<Product> UpdateProduct(Product Product);
        Task<Product> DeleteProduct(int Id);
    }
}
