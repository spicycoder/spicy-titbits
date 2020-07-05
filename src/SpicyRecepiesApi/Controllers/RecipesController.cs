using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SpicyRecipesApi.Models;

namespace SpicyRecipesApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        [HttpGet("all")]
        public ActionResult<ICollection<Recipe>> GetRecipes()
        {
            return Ok(RecipeStore.GetAllRecipes());
        }

        [HttpGet("ingredients")]
        public ActionResult<ICollection<string>> GetIngredients()
        {
            return Ok(RecipeStore.GetAllIngredients());
        }

        [HttpGet("recipe")]
        public ActionResult<ICollection<Recipe>> GetByIngredient(string ingredient)
        {
            return Ok(RecipeStore.GetRecipesByIngredient(ingredient));
        }
    }
}
