using Career_Advisor.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.ComponentModel;

namespace Career_Advisor.Controllers
{
    public class CommentController : Controller
    {
        private static DB _db;
        public CommentController(DB db)
        {
            _db = db;
        }
        // GET: CommentController
        public ActionResult Index()
        {
            List<Comment> comments = new List<Comment>();
            comments = _db.Comments.ToList();
            return View(comments);
        }

        // GET: CommentController/Details/5
        public ActionResult Details(int id)
        {


            var comment = _db.Comments.Where(x => x.Nr.Equals(id)).FirstOrDefault();
           
            return View(comment);
        }

        // GET: CommentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CommentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Comment newComment)
        {
            //comments.Add(newComment);
            return RedirectToAction("Index");
        }

        // GET: CommentController/Edit/5
        public ActionResult Edit(int id)
        {
            var karrieraNeModifikim = _db.Comments.Find(id);
            
            return View(karrieraNeModifikim);
        }

        // POST: CommentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Comment newCommentData)
        {
            try
            {
                var CommentExisting = _db.Comments.Find(newCommentData.Nr);
                if (CommentExisting != null)
                {
                    CommentExisting.Emri = newCommentData.Emri;
                    CommentExisting.Nr = newCommentData.Nr;
                }
                else
                {
                    return View();
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CommentController/Delete/5
        public ActionResult Delete(int id)
        {
            var CommentNeFshirje = _db.Comments.Find(id);
            
            return View(CommentNeFshirje);
        }

        // POST: CommentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ExecuteDelete(int id, IFormCollection collection)
        {
            try
            {
                var CommentneFshirje = _db.Comments.Find(id);
                if(CommentneFshirje!= null)
                {
                    _db.Comments.Remove(CommentneFshirje);
                    _db.SaveChanges();

                    return RedirectToAction(nameof(Index));
                }
                  

            }
            catch
            {
                return View();
            }
        }
    }
}
