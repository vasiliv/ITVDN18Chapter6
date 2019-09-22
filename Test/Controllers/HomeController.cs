using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test.Controllers {
    public class HomeController : Controller {
        OnlineShopEntities db = new OnlineShopEntities();
        public ActionResult Index() {
            ViewBag.Products = new SelectList(db.Products,"Id","Name") ;
            return View();
        }
        [HttpPost]
        public ActionResult ReceiveData() {
            ViewBag.ReceiveData = Products.
            return View();
        }
    }
}