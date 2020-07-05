using System.Collections.Generic;
using System.Linq;

namespace SpicyRecipesApi.Models
{
    public static class RecipeStore
    {
        private static ICollection<Recipe> Recipes
        {
            get
            {
                var recipes = new List<Recipe>
                {
                    new Recipe
                    {
                        Name = "Peri Peri Fries",
                        Ingredients = new List<string>
                        {
                            "Potato",
                            "Peri Peri",
                            "Salt",
                            "Oil"
                        }
                    },
                    new Recipe
                    {
                        Name = "Cookies",
                        Ingredients = new List<string>
                        {
                            "Flour",
                            "Sugar",
                            "Butter",
                            "Choco Chips"
                        }
                    },
                    new Recipe
                    {
                        Name = "Hash Brown Potatoes",
                        Ingredients = new List<string>
                        {
                            "Potato",
                            "Salt",
                            "Oil"
                        }
                    }
                };

                return recipes;
            }
        }

        public static ICollection<Recipe> GetAllRecipes()
        {
            return Recipes;
        }

        public static ICollection<string> GetAllIngredients()
        {
            return Recipes
                .SelectMany(x => x.Ingredients)
                .Distinct()
                .ToList();
        }

        public static ICollection<Recipe> GetRecipesByIngredient(string name)
        {
            return Recipes
                .Where(x => x.Ingredients.Contains(name))
                .ToList();
        }
    }
}