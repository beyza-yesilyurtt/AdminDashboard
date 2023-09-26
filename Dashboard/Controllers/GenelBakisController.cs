using Dashboard.Models;
using Dashboard.Models.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dashboard.Controllers
{
    [_SessionControl]
    public class GenelBakisController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }
    }
}
            