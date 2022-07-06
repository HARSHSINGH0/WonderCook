using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WonderCook.Models
{
    public class RecipeAddViewModelList
    {
        public List<Recipes> RecipesModel { get; set; }
        public List<Macro_Ingredients> Macro_IngredientsModel { get; set; }
        public List<Ingredients> IngredientsModel { get; set; }
        
    }
}

