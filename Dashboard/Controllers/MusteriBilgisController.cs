using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Dashboard.Models.DataContext;
using Dashboard.Models.Müşteri;

namespace Dashboard.Controllers
{
 
    public class MusteriBilgisController : Controller
    {
        private DashboardDbContext db = new DashboardDbContext();

     
        public ActionResult Index()
        {
            return View(db.MusteriBilgis.ToList());
        }

     
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MusteriBilgi musteriBilgi = db.MusteriBilgis.Find(id);
            if (musteriBilgi == null)
            {
                return HttpNotFound();
            }
            return View(musteriBilgi);
        }

        public ActionResult MusteriKart()
        {
            return View(db.MusteriBilgis.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }

      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MusteriBilgiId,MusteriIsim,MusteriSoyisim,MusteriMail,MusteriIletisim,SirketIsmi, SatılanUrun, IletisimeGecenKisi")] MusteriBilgi musteriBilgi)
        {
            if (ModelState.IsValid)
            {
                db.MusteriBilgis.Add(musteriBilgi);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(musteriBilgi);
        }

        
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MusteriBilgi musteriBilgi = db.MusteriBilgis.Find(id);
            if (musteriBilgi == null)
            {
                return HttpNotFound();
            }
            return View(musteriBilgi);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MusteriBilgiId,MusteriIsim,MusteriSoyisim,MusteriMail,MusteriIletisim,SirketIsmi, SatılanUrun, IletisimeGecenKisi")] MusteriBilgi musteriBilgi)
        {
            if (ModelState.IsValid)
            {
                db.Entry(musteriBilgi).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(musteriBilgi);
        }

        //// GET: MusteriBilgis/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null || id == 0)
        //    {
        //        return HttpNotFound();
        //    }
        //    var t = db.MusteriBilgis.Find(id);

        //    db.MusteriBilgis.Remove(t);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}
       
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MusteriBilgi musteriBilgi = db.MusteriBilgis.Find(id);
            if (musteriBilgi == null)
            {
                return HttpNotFound();
            }
           return View(musteriBilgi);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MusteriBilgi musteriBilgi = db.MusteriBilgis.Find(id);
           db.MusteriBilgis.Remove(musteriBilgi);
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
