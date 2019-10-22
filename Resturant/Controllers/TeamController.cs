using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Resturant.Models;

namespace Resturant.Controllers
{
    
    public class TeamController : Controller
    {
        ResturantEntities _context;
        public TeamController()
        {
            _context = new ResturantEntities();
        }
        // GET: Team
        public ActionResult Index()
        {
            var result = _context.Comments.ToList();
            return View(result);
        }

        [HttpPost]
        //[Route("Products/AddProducts/id")]
        public ActionResult AddComment(Comment comment, HttpPostedFileBase userImage,string name, string  com )
        {

            string path = Path.Combine(Server.MapPath("~/Uploads/userImage"), userImage.FileName);
            userImage.SaveAs(path);
            comment.PhotoPath = "/Uploads/userImage/" + userImage.FileName;
            comment.CommentText = com;
            comment.UserName = name;
            comment.CommentDate = DateTime.Now;
            _context.Comments.Add(comment);
            _context.SaveChanges();
            return RedirectToAction("Index" );
        }

    }
}