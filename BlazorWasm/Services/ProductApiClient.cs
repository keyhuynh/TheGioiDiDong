using AppModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorWasm.Services
{
    public class ProductApiClient : IProductApiClient
    {
        public HttpClient _httpClient;
        public ProductApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public Task<Product> AddProduct(Product Product)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetProduct(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Product>> GetProducts(string search)
        {
            var result = await _httpClient.GetFromJsonAsync<List<Product>>($"/api/products?search={search}");
            return result;
        }

        public Task<Product> UpdateProduct(Product Product)
        {
            throw new NotImplementedException();
        }
    }
}
