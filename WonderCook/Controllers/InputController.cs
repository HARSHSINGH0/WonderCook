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
    public class InputController : Controller
    {
        RecipeDatabaseEntities dbObj = new RecipeDatabaseEntities();
        // GET: Input
        public ActionResult Index()
        {
            return View();
        }
        // GET: Image
        [HttpGet]
        public ActionResult AddRecipes()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AddIngredients()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AddMacro_Ingredients()
        {
            return View();
        }
        //private RecipeAddViewModel obj;
        [HttpPost]
        public ActionResult AddRecipesPost(RecipeAddViewModel model)//,Macro_Ingredients model2,Ingredients model3
        {
            Recipes obj = new Recipes();
            //Macro_Ingredients objMac = new Macro_Ingredients();
            //Ingredients objIng = new Ingredients();
            
            obj.recipe_id = model.RecipesModel.recipe_id;
            obj.recipe_name = model.RecipesModel.recipe_name;
            obj.image = model.RecipesModel.image;
            obj.how_to_make = model.RecipesModel.how_to_make;

            //objMac.Id = model2.Id;
            //objMac.nutrient = model2.nutrient;
            //objMac.Recipes_recipe_id = model.recipe_id;

            //objIng.Id = model3.Id;
            //objIng.ingredient = model3.ingredient;
            //objIng.quantity = model3.quantity;
            //objIng.Recipes_recipe_id = model.recipe_id;

            dbObj.Recipes.Add(obj);
            dbObj.SaveChanges();
            
            //try
            //{
            //dbObj.Macro_Ingredients.Add(objMac);
            //dbObj.Ingredients.Add(objIng);
            
            //}
            //catch (System.Data.Entity.Infrastructure.DbUpdateConcurrencyException ex)
            //{
            //    Console.WriteLine(ex.InnerException);
            //}
            //catch (System.Data.Entity.Core.EntityCommandCompilationException ex)
            //{
            //    Console.WriteLine(ex.InnerException);
            //}
            //catch (System.Data.Entity.Core.UpdateException ex)
            //{
            //    Console.WriteLine(ex.InnerException);
            //}

            //catch (System.Data.Entity.Infrastructure.DbUpdateException ex) //DbContext
            //{
            //    Console.WriteLine(ex.InnerException);
            //}

            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.InnerException);
            //    throw;
            //}
            return View("AddRecipes");
        }
        
        [HttpPost]
        public ActionResult AddIngredientsPost(RecipeAddViewModel model)//,Macro_Ingredients model2,Ingredients model3
        {
            Ingredients obj = new Ingredients();
            
            obj.Id = model.IngredientsModel.Id;
            obj.Recipes_recipe_id = model.IngredientsModel.Recipes_recipe_id;
            obj.quantity = model.IngredientsModel.quantity;
            obj.ingredient = model.IngredientsModel.ingredient;

            

            dbObj.Ingredients.Add(obj);
            dbObj.SaveChanges();
            
            return View("AddRecipes");
        }
        [HttpPost]
        public ActionResult AddMacroIngredientsPost(RecipeAddViewModel model)//,Macro_Ingredients model2,Ingredients model3
        {
            Macro_Ingredients obj = new Macro_Ingredients();
            
            obj.Id = model.Macro_IngredientsModel.Id;
            obj.nutrient = model.Macro_IngredientsModel.nutrient;
            obj.Recipes_recipe_id = model.Macro_IngredientsModel.Recipes_recipe_id;
            obj.amount = model.Macro_IngredientsModel.amount;

            

            dbObj.Macro_Ingredients.Add(obj);
            dbObj.SaveChanges();
            
            return View("AddRecipes");
        }
    }
}