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
        public CommentController(DB _db)
        private static List<Comment> comments = new List<Comment>();
        // GET: CommentController
        public ActionResult Index()
        {
            
            return View(comments);
        }

        // GET: CommentController/Details/5
        public ActionResult Details(int id)
        {
            Comment comment = new Comment()
            {
                Nr= 1,
                Emri = "Emri 1"
            };
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
            comments.Add(newComment);
            return RedirectToAction("Index");
        }

        // GET: CommentController/Edit/5
        public ActionResult Edit(int id)
        {
            var KarrieraNeModifikim = comments.Find(x => x.Nr == id);
            // Comment newComment = new Comment();
             //foreach(var item in comments)
              /*{
                  if (item.Nr == id)
                      newComment = item;
              }*/
            return View(KarrieraNeModifikim);
        }

        // POST: CommentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Comment newCommentData)
        {
            try
            {
                var CommentExisting = comments.Find(x => x.Nr == newCommentData.Nr);
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
            var CommentNeFshirje = comments.Find(x => x.Nr == id);
            return View(CommentNeFshirje);
        }

        // POST: CommentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ExecuteDelete(int id)
        {
            try
            {
                var CommentneFshirje = comments.Find(x => x.Nr == id);
                if(CommentneFshirje!= null)
                 comments.Remove(CommentneFshirje);
                    return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
