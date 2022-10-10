using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductManager.Models;

namespace ProductManager.Services
{
    public interface ICategoryService
    {
        List<Category> GetCategories();

        Category? GetCategoryByID(int id);

        void CreateCategory(Category category);

        void UpdateCategory(Category category);
        void DeleteCategory(int id);
    }
}