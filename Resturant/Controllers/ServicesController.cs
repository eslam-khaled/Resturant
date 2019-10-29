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
        ResturantEntities _context;
        public ServicesController()
        {
            _context = new ResturantEntities();
        }
        // GET: Services
        public ActionResult Index()
        {
            var ResAll = _context.Questions.ToList();
            return View(ResAll);
        }

        //Question Section
        //Add Question
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

        //Question Details
        public ActionResult QuestionDetails(int? id)
        {
            var ResDetails = _context.Questions.Where(x => x.QuestionID == id).FirstOrDefault();
            return View(ResDetails);
        }

        //Edit Question
        public ActionResult EditQuestion(int? id)
        {
            Question Question = _context.Questions.Find(id);
            var ResDetails = _context.Questions.Where(x => x.QuestionID == id).FirstOrDefault();
            return View(ResDetails);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditQuestion(Question Question, int id)
        {
            var MyEdit = _context.Questions.Where(c => c.QuestionID == id).FirstOrDefault();
            MyEdit.Question1 = Question.Question1;
            MyEdit.Answer = Question.Answer;
            _context.SaveChanges();

            return View("EditQuestion");
        }

        //Delete Question
        public ActionResult DeleteQuestion(int? id)
        {
            Question Question = _context.Questions.Find(id);
            var ResDetails = _context.Questions.Where(x => x.QuestionID == id).FirstOrDefault();
            return View(ResDetails);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteQuestion(Question Question, int id)
        {
            var MyDel = _context.Questions.Where(c => c.QuestionID == id).FirstOrDefault();
            _context.Questions.Remove(MyDel);
            _context.SaveChanges();

            return View("Index");
        }


    }
}