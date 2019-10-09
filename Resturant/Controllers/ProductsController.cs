using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Resturant.Models;

namespace Resturant.Controllers
{
    public class ProductsController : Controller
    {
        ResturantEntities1 _context;
        public ProductsController()
        {
            _context = new ResturantEntities1();
        }
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }
    }
}