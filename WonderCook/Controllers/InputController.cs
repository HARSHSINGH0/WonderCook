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
        [HttpGet]
        public ActionResult ShowRecipesID()
        {
            Recipes a = new Recipes();
            List<Recipes> recipeList = new List<Recipes>();
            int recipeIDNumber = recipeList.Count();
            ViewData["recipeIDNumber"] = recipeIDNumber.ToString();
            

            return View();
        }



        //private RecipeAddViewModel obj;
        [HttpPost]
        public ActionResult AddRecipesPost(RecipeAddViewModel model, HttpPostedFileBase imageRecipeFile)//,Macro_Ingredients model2,Ingredients model3
        {
            Recipes obj = new Recipes();

            
            obj.recipe_id = model.RecipesModel.recipe_id;
            obj.recipe_name = model.RecipesModel.recipe_name;
            string path = uploadimage(imageRecipeFile);
            if (path.Equals("-1")) { }
            else
            {
                obj.image = path;

            }
            //obj.image = model.RecipesModel.image;
            obj.how_to_make = model.RecipesModel.how_to_make;

          

            dbObj.Recipes.Add(obj);
            dbObj.SaveChanges();
            
         
            return View("AddRecipes");
        }
        public string uploadimage(HttpPostedFileBase imageRecipeFile)

        {

            Random r = new Random();
            string path = "-1";
            int random = r.Next();
            if (imageRecipeFile != null && imageRecipeFile.ContentLength > 0)
            {
                string extension = Path.GetExtension(imageRecipeFile.FileName);
                if (extension.ToLower().Equals(".jpg") || extension.ToLower().Equals(".jpeg") || extension.ToLower().Equals(".png"))
                {
                    try
                    {
                        path = Path.Combine(Server.MapPath("~/Content/upload"), random + Path.GetFileName(imageRecipeFile.FileName));
                        imageRecipeFile.SaveAs(path);
                        path = "~/Content/upload/" + random + Path.GetFileName(imageRecipeFile.FileName);
                        //    ViewBag.Message = "File uploaded successfully";
                    }
                    catch (Exception ex)
                    {
                        path = "-1";
                    }
                }
                else
                {
                    Response.Write("<script>alert('Only jpg ,jpeg or png formats are acceptable....'); </script>");
                }

            }
            else
            {
                Response.Write("<script>alert('Please select a file'); </script>");
                path = "-1";
            }
            return path;
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