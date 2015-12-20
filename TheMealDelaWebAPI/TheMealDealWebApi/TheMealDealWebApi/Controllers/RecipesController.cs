namespace TheMealDealWebApi.Controllers
{
    using Models.TheMealDealModels;
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
                .OrderBy(r => r.Type)
                .Select(RecipeResponseModel.FromModel)
                .ToList();

            if(result == null)
            {
                return this.NotFound();
            }

            return this.Ok(result);
        }

        public IHttpActionResult Get(string ingredients)
        {
            List<string> inputIngredients = ingredients.Split(',').ToList();
            List<Recipe> matched = new List<Recipe>();

            foreach(var recipe in this.db.Recipes)
            {
                int matchCount = 0;
                var recipeIngredients = this.db.Ingredients.Where(i => i.RecipeId == recipe.Id);
                int recipeIngredientsCount = recipeIngredients.Count();
                int inputIngredientCount = inputIngredients.Count();

                if(recipeIngredientsCount > inputIngredientCount + 3)
                {
                    recipe.MatchProcentage = 0;
                    break;
                }

                foreach(var ingredient in recipeIngredients)
                {
                    
                    if(inputIngredients.Contains(ingredient.Name))
                    {
                        matchCount++;
                    }
                }
                recipe.MatchProcentage = (100 * matchCount) / recipeIngredientsCount;
                matched.Add(recipe);
            }

            var result = matched
                    .OrderBy(r => r.MatchProcentage)
                    .ThenBy(r => r.Type)
                    .Select(r => new RecipeResponseModel
                    {
                        Id = r.Id,
                        Title = r.Title,
                        Description = r.Description,
                        Ingredients = (r.Ingredients.Select(i => i.Name)).AsEnumerable().Aggregate((a, b) => (a + ", " + b)),
                        TypeOf = (int)r.Type
                    })
                    .ToList();

            if (result == null)
            {
                return this.NotFound();
            }

            return this.Ok(result);
        }
        
        public IHttpActionResult Get(int id)
        {
            var result = this.db.Recipes
                 .Where(r => r.Id == id)
                 .FirstOrDefault();

            return this.Ok(result);
        }

        [Authorize]
        public IHttpActionResult Post(AddRecipeRequestModel model)
        {
            var currentUser = this.db.Users.FirstOrDefault(u => u.UserName == this.User.Identity.Name);

            ICollection<Ingredient> ingredientConvertion = new List<Ingredient>();
            var inputIngredients = model.Ingredients.Split(',').ToList();
            foreach(var ingredient in inputIngredients)
            {
                ingredientConvertion.Add(new Ingredient(ingredient));
            }

            var newRecipe = new Recipe
            {
                Title = model.Title,
                Description = model.Description,
                Ingredients = ingredientConvertion,
                Type = (Type)model.Type,
                UserId = currentUser.Id
            };

            this.db.Recipes.Add(newRecipe);
            this.db.SaveChangesAsync();

            return this.Ok(newRecipe.Id);
        }
    }
}
