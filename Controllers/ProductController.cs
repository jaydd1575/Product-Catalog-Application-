using WebApplication13.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication13.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            List<Product> P = new List<Product>();
            P = GetProducts();
            return View(P);
        }

        public ActionResult Details(int id)
        {
            List<Product> PALL = GetProducts();
            Product P1 = PALL.FirstOrDefault(p => p.Productid == id);
            return View(P1);
        }

        private List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product
                {
                    Productid = 1,
                    ProductName = "Mobile",
                    Description = "Samsung Mobile",
                    Price = 35000,
                    Category = "Electronics"
                },

                new Product
                {

                    Productid = 2,
                    ProductName = "Laptop",
                    Description = "Dell Laptop",
                    Price = 75000,
                    Category = "Electronics"
                },
                new Product
                {

                    Productid = 3,
                    ProductName = "Headphones",
                    Description = "Wireless Headphones",
                    Price = 7500,
                    Category = "Electronics"
                }
            };
        }
    }
}