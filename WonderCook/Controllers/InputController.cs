using System;
using System.Collections.Generic;
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
        [HttpPost]
        public ActionResult AddRecipesPost(Recipes model,Macro_Ingredients model2,Ingredients model3)
        {
            Recipes obj = new Recipes();
            Macro_Ingredients objMac = new Macro_Ingredients();
            Ingredients objIng = new Ingredients();
            obj.recipe_id = model.recipe_id;
            obj.recipe_name = model.recipe_name;
            obj.image = model.image;
            obj.how_to_make = model.how_to_make;

            objMac.Id = model2.Id;
            objMac.nutrient = model2.nutrient;
            objMac.Recipes_recipe_id = model.recipe_id;

            objIng.Id = model3.Id;
            objIng.ingredient = model3.ingredient;
            objIng.quantity = model3.quantity;
            objIng.Recipes_recipe_id = model.recipe_id;

            
            try
            {
                //dbObj.Macro_Ingredients.Add(objMac);
                //dbObj.Ingredients.Add(objIng);
                dbObj.Recipes.Add(obj);
                dbObj.SaveChanges();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateConcurrencyException ex)
            {
                Console.WriteLine(ex.InnerException);
            }
            catch (System.Data.Entity.Core.EntityCommandCompilationException ex)
            {
                Console.WriteLine(ex.InnerException);
            }
            catch (System.Data.Entity.Core.UpdateException ex)
            {
                Console.WriteLine(ex.InnerException);
            }

            catch (System.Data.Entity.Infrastructure.DbUpdateException ex) //DbContext
            {
                Console.WriteLine(ex.InnerException);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
                throw;
            }
            return View("AddRecipes");
        }
    }
}