using Dashboard.Models.DataContext;
using Dashboard.Models.ProjeTakip;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dashboard.Controllers
{
    public class PersonelProjeController : Controller
    {
        private DashboardDbContext db = new DashboardDbContext();
        public ActionResult Index()
        {
            var projeobj = db.PersonelProjes.ToList();
            return View(projeobj);
        }

        public ActionResult Create()
        {
            ViewBag.PersonelBilgiId = new SelectList(db.PersonelBilgileris, "PersonelBilgiId", "İsim", "Soyisim");
            return View();
        }

        [HttpPost]
        public ActionResult Create(PersonelProje projeobj, int[] PersonelBilgiId)
        {
            foreach(var x in PersonelBilgiId)
            {
                projeobj.PersonelBilgileris.Add(db.PersonelBilgileris.Find(x));
            }
            projeobj.ProjeBaslangıcTarihi = DateTime.Now;
            db.PersonelProjes.Add(projeobj);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var projeobj = db.PersonelProjes.Find(id);
            return View(projeobj);
        }

        [HttpPost]
        public ActionResult Edit(PersonelProje projeobj)
        {
            var personelProje1 = db.PersonelProjes.Find(projeobj.PersonelProjeId);
            personelProje1.ProjeAcıklama = projeobj.ProjeAcıklama;
            personelProje1.ProjeIsim = projeobj.ProjeIsim;
            personelProje1.TamamlanmaOranı = projeobj.TamamlanmaOranı;
            personelProje1.PriorityStatus = projeobj.PriorityStatus;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Tamamla(int id)
        {
            var projeobj = db.PersonelProjes.Find(id);
            projeobj.ProjeDurumu = true;
            projeobj.TamamlanmaOranı = 100;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}