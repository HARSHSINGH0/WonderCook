using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace WonderCook.Components
{
    public class FilteredRecipesViewComponent :ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync() {
            //var recipe= await 
            return View();
        }
    }
}