using AppModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWasm.Services
{
   public interface IProductApiClient
    {
        Task<List<Product>> GetProducts(string search = null);
        Task<Product> GetProduct(int Id);
        Task<Product> AddProduct(Product Product);
        Task<Product> UpdateProduct(Product Product);
        void DeleteProduct(int Id);
    }
}
