//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WonderCook.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ingredients
    {
        public int Id { get; set; }
        public string ingredient { get; set; }
        public string quantity { get; set; }
        public int Recipes_recipe_id { get; set; }
    }
}
