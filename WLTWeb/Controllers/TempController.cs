using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WLTWeb.Models;

namespace WLTWeb.Controllers
{
    public class TempController : Controller
    {
        // GET: Temp
        Model1 _db = new Model1();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult getMenu()
        {
            var v = from t in _db.Menu
                    where t.hide == true
                    orderby t.order ascending
                    select t;
            return PartialView(v.ToList());
        }
    }
}