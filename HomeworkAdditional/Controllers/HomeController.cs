using HomeworkAdditional.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeworkAdditional.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }
        [HttpPost]
        public ActionResult Add(User user) {
            Debug.WriteLine("Id = " + user.Id);
            Debug.WriteLine("First Name = " + user.FirstName);
            Debug.WriteLine("Last Name = " + user.LastName);
            return View("Success");
        }
    }
}