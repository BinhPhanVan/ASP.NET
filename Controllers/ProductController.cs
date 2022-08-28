// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;

// using ProductManager.Models;
// using ProductManager.Services;

// namespace ProductManager.Controllers
// {
//     public class ProductController : Controller
//     {
//     //     public List<Product> Products { get; set; }
//     //     public ProductController()
//     //     {
//     //         // Products = new List<Product>(){
//     //         //     new Product(){Id = 1, Name = "Nguyen Van A", Price = 500, Quantity = 400},
//     //         //     new Product(){Id = 2, Name = "Nguyen Van b", Price = 500, Quantity = 400},
//     //         //     new Product(){Id = 3, Name = "Nguyen Van c", Price = 500, Quantity = 400}
//     //         // };
//     //     }
//     //     public IActionResult Index()
//     //     {
//     //         var categories =  new List<string>()
//     //             {
//     //                 "SmartPhone", 
//     //                 "TV"
//     //             };
//     //         return View(Products);
//     //     }
//     // }
//     // public class ProductService : Controller
//     // {
//     //     private readonly DataContext _context;
//     //     public ProductController(DataContext context)
//     //     {
//     //         _context = context;
//     //     }
 
//     //     public IActionResult Index()
//     //     {
//     //         var products = _context.Products.ToList();
//     //         return View(products);
//     //     }
//     // }
//     public class ProductService : IProductService
//     {
//         private readonly DataContext _context;
//         public ProductService(DataContext context)
//         {
//             _context = context;
//         }
//         public List<Product> GetProducts()
//         {
//             return _context.Products.ToList();
//         }
//     }


//     }
// }


using Microsoft.AspNetCore.Mvc;
using ProductManager.Services;
 
namespace ProductManager.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
 
        public IActionResult Index()
        {
            var products = _productService.GetProducts();
            return View(products);
        }
    }
}
