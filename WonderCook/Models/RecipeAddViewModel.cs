using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WonderCook.Models
{
    public class RecipeAddViewModel
    {
        public Recipes RecipesModel { get; set; }
        public Macro_Ingredients Macro_IngredientsModel { get; set; }
        public Ingredients IngredientsModel { get; set; }


    }
}