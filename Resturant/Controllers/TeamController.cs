using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Resturant.Models;

namespace Resturant.Controllers
{
    
    public class TeamController : Controller
    {
        ResturantEntities1 _context;
        public TeamController()
        {
            _context = new ResturantEntities1();
        }
        // GET: Team
        public ActionResult Index()
        {
            return View();
        }
    }
}