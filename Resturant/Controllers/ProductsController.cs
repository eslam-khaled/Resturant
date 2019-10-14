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
        // GET: All Products
        public ActionResult Index()
        {
            var ResAll = _context.Products;
            return View();
        }
        //Get: Product Details
        public ActionResult ProductDetails(int? id)
        {
            var ResDetails = _context.Products.Where(x => x.ProductID == id).FirstOrDefault();
            return View(ResDetails);
        }
        public ActionResult AddProducts()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddProducts(Product product)
        {
                _context.Products.Add(product);
                _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}