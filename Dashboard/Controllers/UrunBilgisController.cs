using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Dashboard.Models.DataContext;
using Dashboard.Models.Urunler;

namespace Dashboard.Controllers
{
    public class UrunBilgisController : Controller
    {
        private DashboardDbContext db = new DashboardDbContext();

        // GET: UrunBilgis
        public ActionResult Index()
        {
            return View(db.UrunBilgis.ToList());
        }

        // GET: UrunBilgis/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UrunBilgi urunBilgi = db.UrunBilgis.Find(id);
            if (urunBilgi == null)
            {
                return HttpNotFound();
            }
            return View(urunBilgi);
        }

        // GET: UrunBilgis/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UrunBilgis/Create
        // Aşırı gönderim saldırılarından korunmak için, bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UrunBilgiId,UrunIsim,UrunAciklama,UrunFiyat,SatınAlanMüşteri,İletişimeGecenKisi")] UrunBilgi urunBilgi)
        {
            if (ModelState.IsValid)
            {
                db.UrunBilgis.Add(urunBilgi);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(urunBilgi);
        }

        // GET: UrunBilgis/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UrunBilgi urunBilgi = db.UrunBilgis.Find(id);
            if (urunBilgi == null)
            {
                return HttpNotFound();
            }
            return View(urunBilgi);
        }

        // POST: UrunBilgis/Edit/5
        // Aşırı gönderim saldırılarından korunmak için, bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UrunBilgiId,UrunIsim,UrunAciklama,UrunFiyat,SatınAlanMüşteri,İletişimeGecenKisi")] UrunBilgi urunBilgi)
        {
            if (ModelState.IsValid)
            {
                db.Entry(urunBilgi).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(urunBilgi);
        }

        // GET: UrunBilgis/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UrunBilgi urunBilgi = db.UrunBilgis.Find(id);
            if (urunBilgi == null)
            {
                return HttpNotFound();
            }
            return View(urunBilgi);
        }

        // POST: UrunBilgis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UrunBilgi urunBilgi = db.UrunBilgis.Find(id);
            db.UrunBilgis.Remove(urunBilgi);
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
