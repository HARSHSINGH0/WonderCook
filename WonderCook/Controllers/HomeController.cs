using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
        public ActionResult Recipe()
        {

            return View();
        }
        public ActionResult ChefInput()
        {
            return View();
        }
        //public ActionResult ViewAll()
        //{
        //    return View(GetAllRecipes);
        //}
        //IEnumerable<ChefInput> GetAllRecipes()
        //{
        //    using (RecipesModel)
        //}

    }
}