using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Dashboard.Models.DataContext;
using Dashboard.Models.Personel;

namespace Dashboard.Controllers
{
 
    public class LoginController : Controller
    {
        private DashboardDbContext db = new DashboardDbContext();

        
        public ActionResult Login()
        {
            return View();
        }

    [HttpPost]
        public JsonResult girisYap(PersonelBilgileri admin)
        {
            string sonuc = "";

            DashboardDbContext db = new DashboardDbContext();
            var bilgiler = db.PersonelBilgileris.FirstOrDefault(x => x.Mail == admin.Mail && x.Sifre == admin.Sifre);
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(admin.Mail, false);
                Session["kullanici"] = bilgiler.PersonelBilgiId.ToString();

                sonuc = bilgiler.PersonelBilgiId.ToString();
                //return RedirectToAction("Index","PersonelBilgileris");
            }

            //ViewBag.hata = "Kullanıcı adı veya şifre hatalı";
            //return View();

            return Json(sonuc, JsonRequestBehavior.AllowGet);

        }
       
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");
        }

       
    }
}
