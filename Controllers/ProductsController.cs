using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab2.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products

        public ActionResult Index()
        {


            string[] products = { "Laptop", "Tablet", "Mobile" };

            ViewData["products"] = products;

            return View();

        }
        public ActionResult Details(string product)
        {
            ViewBag.Message = "You have selected " + product;
            return View();


        }
    }
}