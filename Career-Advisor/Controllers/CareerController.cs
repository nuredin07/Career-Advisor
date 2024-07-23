using Career_Advisor.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace Career_Advisor.Controllers
{
    public class CareerController : Controller
    {
        private static List<Career> careers = new List<Career>();
        // GET: CareerController
        public ActionResult Index()
        {
            List < Career > list  = new List < Career >();
            return View(list);
        }

        // GET: CareerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CareerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CareerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CareerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CareerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CareerController/Delete/5
        public ActionResult Delete(int id)
        {
            var CareerNeFshirje = careers.Find(x => x.Nr == id);
            return View(CareerNeFshirje);
        }

        // POST: CareerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ExecuteDelete(int id)
        {
            try
            {
                var CareerneFshirje = careers.Find(x => x.Nr == id);
                if (CareerneFshirje != null)
                    careers.Remove(CareerneFshirje);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
