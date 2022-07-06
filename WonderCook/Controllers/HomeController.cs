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
        //public ActionResult Menu(List<string> AllIngredients_posted)
        //{
        //    List<string> AllIngredients_posted1 = AllIngredients_posted;
        //    return View(dbObj.Recipes.ToList());
        //}
        public ActionResult SearchView()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Getrecipes(string term)
        {
            
            List<string> RecipesString = dbObj.Recipes.Where(s => s.recipe_name.StartsWith(term)).Select(x => x.recipe_name).ToList();

            return Json(RecipesString, JsonRequestBehavior.AllowGet);
        }
        public ActionResult buttonCheck()
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
            //List<string> AllIngredient=new List<string>();
            //AllIngredient.Add("test");

            return View();
        }
        //[HttpPost]
        //public ActionResult SideViewPost()//,Macro_Ingredients model2,Ingredients model3
        //{
            
        //    return View();//this may give error if there is no input or something i dont know that i m saying
        //}
        [HttpPost]
        public ActionResult SideViewPost(List<string> ALLingredients_post)//,Macro_Ingredients model2,Ingredients model3
        {
            //Recipe(ALLingredients_post);
            
            return View();//this may give error if there is no input or something i dont know that i m saying
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