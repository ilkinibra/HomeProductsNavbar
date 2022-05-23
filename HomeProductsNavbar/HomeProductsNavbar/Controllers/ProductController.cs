using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeProductsNavbar.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HomeProductsNavbar.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index(string search)
        {
            List<Product> products = new List<Product>()
            {
                new Product
                {
                    Id = 1,
                    Name = "Apple",
                    Description = "Test 1 desc",
                    Image = "headphone.jpeg",
                    Price = 2000
                },
                new Product
                {
                    Id = 2,
                    Name = "Samsung",
                    Description = "Test 2 desc",
                    Image = "headphone.jpeg",
                    Price = 1090
                },
                new Product
                {
                    Id = 3,
                    Name = "Xiomi",
                    Description = "Test 3 desc",
                    Image = "headphone.jpeg",
                    Price = 103
                }
            };

            if (!string.IsNullOrWhiteSpace(search))
            {
                products = products.FindAll(p => p.Name.ToLower().Contains(search.ToLower()));
                if (products.Count == 0)
                    return NotFound();
            }

            return View(products);
        }
    }
}