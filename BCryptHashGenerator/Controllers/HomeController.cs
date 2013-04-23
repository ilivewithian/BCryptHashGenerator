using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BCryptHashGenerator.Models;

namespace BCryptHashGenerator.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            return View(new HomeModel());
        }

        [HttpPost]
        public ActionResult Index(HomeModel model)
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            if (model == null || !ModelState.IsValid)
            {
                return View(new HomeModel());
            }

            model.BCryptHash = BCrypt.Net.BCrypt.HashPassword(model.PlainText);

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
