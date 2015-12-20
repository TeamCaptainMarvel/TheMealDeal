namespace TheMealDealWebApi.Models.TheMealDealModels
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;
    using TheMealDeal.Models;

    public class RecipeResponseModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Ingredients { get; set; }

        public int TypeOf { get; set; }

        public static Expression<Func<Recipe, RecipeResponseModel>> FromModel
        {
            get
            {
                return r => new RecipeResponseModel
                {
                    Id = r.Id,
                    Title = r.Title,
                    Description = r.Description,
                    Ingredients = (r.Ingredients.Select(i => i.Name)).AsEnumerable().Aggregate((a, b) => (a + ", " + b)),
                    TypeOf = (int)r.Type
                };
            }
        }
    }
}