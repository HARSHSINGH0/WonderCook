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
        [HttpGet]//[HttpGet]
        public ActionResult AddRecipes()
        {
            
            return View(new RecipeAddViewModel());
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
        
        public ActionResult ShowRecipe()
        {
            return View(dbObj.Recipes.ToList());
            //return View();
        }



        //private RecipeAddViewModel obj;
        [HttpPost]
        public ActionResult AddRecipesPost(RecipeAddViewModel model, HttpPostedFileBase imageRecipe)//,Macro_Ingredients model2,Ingredients model3
        {
            Recipes obj = new Recipes();

            
            obj.recipe_id = model.RecipesModel.recipe_id;
            obj.recipe_name = model.RecipesModel.recipe_name;
            if (imageRecipe != null)
            {

                model.RecipesModel.image = new byte[imageRecipe.ContentLength];
                imageRecipe.InputStream.Read(model.RecipesModel.image, 0, imageRecipe.ContentLength);

            }
            obj.image = model.RecipesModel.image;
            obj.how_to_make = model.RecipesModel.how_to_make;

          

            dbObj.Recipes.Add(obj);
            dbObj.SaveChanges();
            
         
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