using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Drawing;
using System.IO;
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
            //List<RecipeAddViewModel> viewModelAll = new List<RecipeAddViewModel>();
            
            return View(dbObj.Recipes.ToList());//(viewModelAll.ToList()
        }
        public ActionResult Menu()
        {
            
            return View(dbObj.Recipes.ToList());
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

            //List<RecipeAddViewModel> viewModelAll = new List<RecipeAddViewModel>();

            //viewModelAll.Add(new RecipeAddViewModel()); 
            //return View(viewModelAll.ToList());//"recipe",viewModelAll.AsEnumerable()// dbObj.Recipes.ToList(), //
            RecipeAddViewModelList model = new RecipeAddViewModelList();
            
            model.RecipesModel = dbObj.Recipes.ToList();
            model.IngredientsModel = dbObj.Ingredients.ToList();
            model.Macro_IngredientsModel = dbObj.Macro_Ingredients.ToList();
            return View(model);
        }
        //public ActionResult Recipe(int id)
        //{
        
        //        List<RecipeAddViewModel> viewModelAll = new List<RecipeAddViewModel>();
                
        //        viewModelAll.Add(new RecipeAddViewModel()); 
        //        return View(dbObj.Recipes.ToList());//"recipe",viewModelAll.AsEnumerable()// dbObj.Recipes.ToList(), 
        //}

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