using System.Collections.Generic;

namespace SpicyRecipesApi.Models
{
    public class Recipe
    {
        public string Name { get; set; }
        public ICollection<string> Ingredients { get; set; }
    }
}