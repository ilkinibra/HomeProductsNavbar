using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeProductsNavbar.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HomeProductsNavbar.Controllers
{
    public class DetailsController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index(int id)
        {
            List<ProductDetails> ProductDetails = new List<ProductDetails>()
            {

                new ProductDetails
                {
                    ProductId=1,
                    Id = 1,
                    BatteryCapacity = 100,
                    Garanty = 1,
                    CreateDate = 2020
                },
                new ProductDetails
                {
                    ProductId=2,
                    Id = 2,
                    BatteryCapacity = 100,
                    Garanty = 2,
                    CreateDate = 2021
                },

                new ProductDetails
                 {
                    ProductId=3,
                    Id = 3,
                    BatteryCapacity = 100,
                    Garanty = 3,
                    CreateDate = 2022
                 },
            };
            var Details = ProductDetails.FirstOrDefault(p => p.ProductId == id);
            return View(Details);
        }
    }
}
