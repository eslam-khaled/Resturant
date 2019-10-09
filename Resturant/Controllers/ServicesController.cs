using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Resturant.Models;

namespace Resturant.Controllers
{
    public class ServicesController : Controller
    {
        ResturantEntities1 _context;
        public ServicesController()
        {
            _context = new ResturantEntities1();
        }
        // GET: Services
        public ActionResult Index()
        {
            return View();
        }
    }
}