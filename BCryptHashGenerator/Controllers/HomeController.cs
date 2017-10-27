using System;
using System.Web;
using System.Web.Mvc;
using BCryptHashGenerator.Models;

namespace BCryptHashGenerator.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index(HomeModel model)
        {
            var uriBuilder = new UriBuilder(new Uri("https://passwordhashing.com/BCrypt"));

            var queryString = HttpUtility.ParseQueryString(string.Empty);

            queryString["utm_source"] = "BCHG";
            queryString["utm_campaign"] = "DomainMigration";

            if (!string.IsNullOrWhiteSpace(model.PlainText))
            {
                queryString["plainText"] = model.PlainText;
            }

            uriBuilder.Query = queryString.ToString();

            return RedirectPermanent(uriBuilder.ToString());
        }
    }
}
