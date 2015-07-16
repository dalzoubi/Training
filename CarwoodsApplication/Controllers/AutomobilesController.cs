using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using CarwoodsApplication.Models;

namespace CarwoodsApplication.Controllers
{
    [Authorize]
    public class AutomobilesController : Controller
    {
        private CarwoodsApplicationContext db = new CarwoodsApplicationContext();

        // GET: Automobiles
        public ActionResult Index()
        {
            var automobiles = db.Automobiles.Include(a => a.Maker);
            return View(automobiles.OrderBy(a => a.Model).ToList());
        }

        // GET: Automobiles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Automobile automobile = db.Automobiles.Find(id);
            if (automobile == null)
            {
                return HttpNotFound();
            }
            return View(automobile);
        }

        // GET: Automobiles/Create
        public ActionResult Create()
        {
            ViewBag.MakerId = new SelectList(db.Makers, "MakerId", "Title");
            return View();
        }

        // POST: Automobiles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AutomobileId,MakerId,Model,Year,Description,MsrpPrice")] Automobile automobile)
        {
            if (ModelState.IsValid)
            {
                db.Automobiles.Add(automobile);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MakerId = new SelectList(db.Makers, "MakerId", "Title", automobile.MakerId);
            return View(automobile);
        }

        // GET: Automobiles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Automobile automobile = db.Automobiles.Find(id);
            if (automobile == null)
            {
                return HttpNotFound();
            }
            ViewBag.MakerId = new SelectList(db.Makers, "MakerId", "Title", automobile.MakerId);
            return View(automobile);
        }

        // POST: Automobiles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AutomobileId,MakerId,Model,Year,Description,MsrpPrice")] Automobile automobile)
        {
            if (ModelState.IsValid)
            {
                db.Entry(automobile).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MakerId = new SelectList(db.Makers, "MakerId", "Title", automobile.MakerId);
            return View(automobile);
        }

        // GET: Automobiles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Automobile automobile = db.Automobiles.Find(id);
            if (automobile == null)
            {
                return HttpNotFound();
            }
            return View(automobile);
        }

        // POST: Automobiles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Automobile automobile = db.Automobiles.Find(id);
            db.Automobiles.Remove(automobile);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
