using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesASPCoreMVCWebApp.Models
{
    public class Recipe
    {
        // prop tab tab -> to create property
        public int Id { get; set; }
        public string RecipeName { get; set; }
        public string RecipeCat { get; set; }
        public DateTime RecipeDate { get; set; }
        public string ingredients { get; set; }
        public string PrepMtd { get; set; }
        public int PrepTime { get; set; }
        public int CookingTime { get; set; }
        public int Servings { get; set; }

        // ctor tab tab - to create  a function called constructor
        public Recipe()
        {

        }

    }

    
}
