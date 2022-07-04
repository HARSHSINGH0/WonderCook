using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WonderCook.Models;

namespace WonderCook.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public JsonResult Getemp(string Recipe_name)
        {
            RecipesModelContainer sdb = new RecipesModelContainer();
            var recipe = (from x in sdb.Recipes where x.recipe_name.StartsWith(Recipe_name) select new { label = x.recipe_name }).ToList();
            return Json(recipe);
        }
    }
}