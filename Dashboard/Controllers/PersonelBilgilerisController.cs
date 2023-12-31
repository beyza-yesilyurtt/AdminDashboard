﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Dashboard.Models;
using Dashboard.Models.DataContext;
using Dashboard.Models.Personel;

namespace Dashboard.Controllers
{
    [_SessionControl]
    public class PersonelBilgilerisController : Controller
    {
        private DashboardDbContext db = new DashboardDbContext();
               
        public ActionResult Index()
        {
            return View(db.PersonelBilgileris.ToList());
        }
        public ActionResult PersonelKart()
        {
            return View(db.PersonelBilgileris.ToList());
        }

      
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonelBilgileri personelBilgileri = db.PersonelBilgileris.Find(id);
            if (personelBilgileri == null)
            {
                return HttpNotFound();
            }
            return View(personelBilgileri);
        }

        
        public ActionResult Create()
        {
            return View();
        }

        // POST: PersonelBilgileris/Create
        // Aşırı gönderim saldırılarından korunmak için, bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PersonelBilgiId,Mail,Sifre,Yetki,İsim,Soyisim,PersonelResim,TCND,Departman,Görev,PozisyonAcıklama,TelefonNumarası,AdresBilgi,DogumTarihi,IseBaslamaTarihi,Aktif")] PersonelBilgileri personelBilgileri)
        {
            if (ModelState.IsValid)
            {
                db.PersonelBilgileris.Add(personelBilgileri);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(personelBilgileri);
        }

        // GET: PersonelBilgileris/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonelBilgileri personelBilgileri = db.PersonelBilgileris.Find(id);
            if (personelBilgileri == null)
            {
                return HttpNotFound();
            }
            return View(personelBilgileri);
        }

        // POST: PersonelBilgileris/Edit/5
        // Aşırı gönderim saldırılarından korunmak için, bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PersonelBilgiId,Mail,Sifre,Yetki,İsim,Soyisim,PersonelResim,TCND,Departman,Görev,PozisyonAcıklama,TelefonNumarası,AdresBilgi,DogumTarihi,IseBaslamaTarihi,Aktif")] PersonelBilgileri personelBilgileri)
        {
            if (ModelState.IsValid)
            {
                db.Entry(personelBilgileri).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(personelBilgileri);
        }

    



        //// GET: PersonelBilgileris/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    PersonelBilgileri personelBilgileri = db.PersonelBilgileris.Find(id);
        //    if (personelBilgileri == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(personelBilgileri);
        //}

        //// POST: PersonelBilgileris/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    PersonelBilgileri personelBilgileri = db.PersonelBilgileris.Find(id);
        //    db.PersonelBilgileris.Remove(personelBilgileri);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        public ActionResult Delete(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return HttpNotFound();
            }
            var t = db.PersonelBilgileris.Find(Id);

            db.PersonelBilgileris.Remove(t);
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
