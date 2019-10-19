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
            var ResAll = _context.Questions.ToList();
            return View(ResAll);
        }
         public ActionResult AddQuestions()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddQuestions(Question question)
        {
            _context.Questions.Add(question);
            _context.SaveChanges();
            return View("AddQuestions");
        }
        public ActionResult QuestionDetails(int? id)
        {
            var ResDetails = _context.Questions.Where(x => x.QuestionID == id).FirstOrDefault();
            return View(ResDetails);
        }
        
        



    }
}