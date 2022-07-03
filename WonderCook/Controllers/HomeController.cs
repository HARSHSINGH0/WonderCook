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
        RecipeDatabaseEntities dbObj = new RecipeDatabaseEntities();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Menu()
        {
            return View();
        }
        

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        
        public ActionResult SideView()
        {
            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Recipe()
        {
        
                List<RecipeAddViewModel> viewModelAll = new List<RecipeAddViewModel>();
            
                viewModelAll.Add(new RecipeAddViewModel()); 
                return View(dbObj.Recipes.ToList());//"recipe",viewModelAll.AsEnumerable()// dbObj.Recipes.ToList(), 
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