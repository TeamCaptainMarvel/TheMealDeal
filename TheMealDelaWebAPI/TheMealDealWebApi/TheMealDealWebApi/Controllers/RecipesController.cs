namespace TheMealDealWebApi.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Http;
    using TheMealDeal.Data;
    using TheMealDeal.Models;
    public class RecipesController : ApiController
    {
        private readonly TheMealDealDbContext db;

        public RecipesController()
        {
            this.db = new TheMealDealDbContext();
        }

        public IHttpActionResult Get()
        {
            var result = this.db
                .Recipes
                .OrderBy(r => r.Ingredients)
                .ToList();

            return this.Ok(result);
        }

        public IHttpActionResult Get(string ingredients)
        {
            List<string> inpuIngredients = ingredients.Split(',').ToList();
            List<Recipe> matched = new List<Recipe>();

            foreach(var recipe in this.db.Recipes)
            {
                int matchCount = 0;
                var recipeIngredients = recipe.Ingredients;
                int recipeIngredientsCount = recipeIngredients.Count();
                int inputIngredientCount = inpuIngredients.Count();

                if(recipeIngredientsCount > inputIngredientCount + 3)
                {
                    break;
                }
                foreach(var ingredient in inpuIngredients)
                {
                    if(recipeIngredients.Contains(ingredient))
                    {
                        matchCount++;
                    }
                }
                recipe.MatchProcentage = (100 * inputIngredientCount) / recipeIngredientsCount;
                matched.Add(recipe);

                var result = matched.OrderBy(r => r.MatchProcentage).ToList();
                return this.Ok(matched);
            }
        }

        private int TypeConverter(string type)
        {
            switch (type)
            {
                case "vegeterian":
                    return 0;
                case "vegan":
                    return 1;
                case "meat":
                    return 2;
                default:
                    return -1;
            }

        }
    }
}
