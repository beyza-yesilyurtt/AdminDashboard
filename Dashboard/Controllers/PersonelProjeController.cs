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
            var projeListele = db.PersonelProjeleris.ToList();
            return View(projeListele);
        }

        public ActionResult Create()
        {
            ViewBag.PersonelBilgiId = new SelectList(db.PersonelBilgileris, "PersonelBilgiId", "İsim", "Soyisim");
            return View();
        }

        [HttpPost]
        public ActionResult Create(PersonelProje personelProje, int[] PersonelBilgiId)
        {
            foreach(var x in PersonelBilgiId)
            {
                personelProje.PersonelBilgileris.Add(db.PersonelBilgileris.Find(x));
            }
            personelProje.ProjeBaslangıcTarihi = DateTime.Now;
            db.PersonelProjeleris.Add(personelProje);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}