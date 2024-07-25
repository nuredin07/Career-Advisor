using Career_Advisor.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace Career_Advisor.Controllers
{
    public class CareerController : Controller

    {
        private static DB _db;
        private static List<Career> careers = new List<Career>();

        public CareerController(DB db)
        {
            _db = db;
        }
        // GET: CareerController
        public ActionResult Index()
        {
            List < Career > list  = new List < Career >();
            list = _db.Careers.ToList();
            return View(list);
        }

        // GET: CareerController/Details/5
        public ActionResult Details(int id)
        {
            var career = _db.Careers.Where(x => x.Nr.Equals(id)).FirstOrDefault();
            return View(career);
        }

        // GET: CareerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CareerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Career NewCr)
        {
            try
            {
                _db.Careers.Add(NewCr);
                _db.SaveChanges();
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
            var CrNeNdryshim = _db.Careers.Find(id);
            return View(CrNeNdryshim);
        }

        // POST: CareerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Career CrNeNdryshim)
        {
            try
            {
                var CrOrginal = _db.Careers.Find(CrNeNdryshim.Nr);
                CrOrginal.Emri = CrNeNdryshim.Emri;
                _db.SaveChanges();
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
            var CareerNeFshirje = _db.Careers.Find(id);
            return View(CareerNeFshirje);
        }

        // POST: CareerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ExecuteDelete(int id)
        {
            try
            {
                var CareerneFshirje = _db.Careers.Find(id);
                _db.Careers.Remove(CareerneFshirje);
                _db.SaveChanges();
                    
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
