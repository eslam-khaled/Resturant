using Resturant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Resturant.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        //POST
        [HttpPost]
        public ActionResult Index(UserModel model)
        {
            ResturantEntities cbe = new ResturantEntities();
            var s = cbe.GetLoginInfo(model.UserName, model.Password);

            var item = s.FirstOrDefault();
            if (item == "Success")
            {

                return RedirectToAction("Index","Home");
            }
            else if (item == "User Does not Exists")

            {
                ViewBag.NotValidUser = item;

            }
            else
            {
                ViewBag.Failedcount = item;
            }

            return View("Index");
        }

        //The action UserLandingView will be called, 
        //when the user posts the data after entering UserName and Password field.
        //There is a successful login. 
        public ActionResult UserLandingView()
        {
            return View();
        }
    }
}