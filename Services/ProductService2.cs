using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductManager.Models;

namespace ProductManager.Services
{
    public class ProductService2 : IProductService
    {
        private readonly DataContext _context;
        public ProductService2(DataContext context)
        {
            _context = context;
        }

        public void CreateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetCategories()
        {
            throw new NotImplementedException();
        }

        public Product GetProductByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProducts()
        {
            return _context.Products.OrderByDescending(x => x.Id).ToList();
        }

        public void UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}