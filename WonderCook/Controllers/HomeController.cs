using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

using WonderCook.Models;

namespace WonderCook.Controllers
{
    public class HomeController : Controller
    {
        RecipeDatabaseEntities dbObj = new RecipeDatabaseEntities();

        //public ActionResult Index(List<Recipes> menus)
        //{
        //    //List<RecipeAddViewModel> viewModelAll = new List<RecipeAddViewModel>();

        //    if (menus == null)
        //    {
        //        return View(dbObj.Recipes.ToList());
        //    }
        //    else
        //    {
        //        foreach (var item in menus)
        //        {
        //            System.Diagnostics.Debug.WriteLine(item);
        //        }
        //        return View(menus);//(viewModelAll.ToList()
        //    }
        //}



        //public ActionResult Menu(IEnumerable<Recipes> menus)
        //{


        //    return View(dbObj.Recipes.ToList());
        //}

        [HttpPost]
        public JsonResult Getemp(string Recipe_name)
        {
            RecipeDatabaseEntities sdb = new RecipeDatabaseEntities();
            var recipe = (from x in sdb.Recipes where x.recipe_name.StartsWith(Recipe_name) select new { label = x.recipe_name }).ToList();
            System.Diagnostics.Debug.WriteLine(recipe);
            //return Json(recipe);
            return Json(recipe);
        }
        public ActionResult SearchBar()
        {
            return View(dbObj.Recipes.ToList());
        }
        public ActionResult Menu()
        {
            return View(dbObj.Recipes.ToList());
        }

        
        
        
        //[System.Web.Http.HttpGet]
        public ActionResult Index(List<string> AllIngredients_posted)
        {
            if (AllIngredients_posted == null)
            {
                return View(dbObj.Recipes.ToList());
            }
            //Recipes model = new Recipes();
            RecipeAddViewModelList modelistALL = new RecipeAddViewModelList();
            //IEnumerable<Ingredients> menusIngr = dbObj.Ingredients;
            IEnumerable<Ingredients> menusIngr = dbObj.Ingredients;
            List<string> recipeIDPosted = new List<string>();
            if (AllIngredients_posted == null) { return View("Index"); }
            //System.Diagnostics.Debug.WriteLine(menusIngr);
            foreach (var ingrPosted in AllIngredients_posted)
            {
                //System.Diagnostics.Debug.WriteLine(ingr.ingredient);
                foreach (var ingr in menusIngr)
                {
                    //System.Diagnostics.Debug.WriteLine(ingr.ingredient);
                    if (ingrPosted == ingr.ingredient)
                    {
                        recipeIDPosted.Add(ingr.Recipes_recipe_id.ToString());
                    }
                }
            }
            IEnumerable<Recipes> menus = Enumerable.Empty<Recipes>();
            
            menus = menus.ToList();
            foreach (var item in recipeIDPosted)
            {
                menus=menus.Concat(dbObj.Recipes.Where(t => item.Contains(t.recipe_id.ToString())));//before that search concat not working//maybe try to conver to list and then convert to iEnumberable 
                //menus = menus.ToList();
            }
            //System.Diagnostics.Debug.WriteLine("menus length:" +menus.Count());
            foreach (var item in menus)
            {
                
                System.Diagnostics.Debug.WriteLine("menus:" + item.recipe_name);
            }
            //menus=menus.ToList();
            //IEnumerable<Recipes> menus = dbObj.Recipes
            //.Select(x => x)
            //.Where(x => (x.MenuCategory == x.category)
            //.OrderBy(x => x.MenuSequence).ToList();
            HttpContext.Session.Clear();
            //return View("Index",menus);
            //return RedirectToAction("Index",menus);
            //return Redirect("Index");
            return View("Index",menus);
            //return PartialView("Menu", menus);
           
        }

        public ActionResult SearchView()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Getrecipes(string term)
        {
            //RecipeDatabaseEntities dbObj = new RecipeDatabaseEntities();
            List<string> RecipesString = dbObj.Recipes.Where(s => s.recipe_name.StartsWith(term)).Select(x => x.recipe_name).ToList();

            System.Diagnostics.Debug.WriteLine(RecipesString);
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
        public ActionResult SideViewTest()
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
            RecipeAddViewModelList model = new RecipeAddViewModelList();
            model.RecipesModel = dbObj.Recipes.ToList();
            model.IngredientsModel = dbObj.Ingredients.ToList();
            model.Macro_IngredientsModel = dbObj.Macro_Ingredients.ToList();
            return View(model);
        }
        public ActionResult ChefInput()
        {
            return View();
        }

    }
}