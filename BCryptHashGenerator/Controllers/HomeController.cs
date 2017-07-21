﻿using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using BCryptHashGenerator.Models;
using CryptSharp;

namespace BCryptHashGenerator.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index(HomeModel model)
        {

            var list = HttpContext.Application["RecentItems"] as List<string> ?? new List<string>();
            if (!string.IsNullOrEmpty(model.PlainText) && !list.Contains(model.PlainText))
            {
                list.Add(model.PlainText);
            }
            HttpContext.Application["RecentItems"] = new List<string>();
            //HttpContext.Application["RecentItems"] = list.AsEnumerable().Reverse().Take(10).Reverse().ToList();


            if (!string.IsNullOrEmpty(model.PlainText))
            {                
                model.BCryptHash = Crypter.Blowfish.Crypt(model.PlainText);
            }

            return View(model);
        }
    }
}
