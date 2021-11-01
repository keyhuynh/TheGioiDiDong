using AppModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Repositories
{
    public  interface ICategoryRepository
    {
        Task<List<Category>> GetCategories();
        Task<Category> GetCategory(int Id);
        Task<Category> AddCategory(Category category);
        Task<Category> UpdateCategory(Category category);
        void DeleteCategory(int Id);
    }
}
