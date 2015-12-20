namespace TheMealDealWebApi.Models.TheMealDealModels
{
    using System.ComponentModel.DataAnnotations;
    using TheMealDeal.Common.Constants;

    public class AddRecipeRequestModel
    {
        [Required]
        [MaxLength(ValidationConstants.RecipeTitleMaxLenght)]
        public string Title { get; set; }

        [Required]
        [MinLength(ValidationConstants.RecipeDescriptionMinLength)]
        public string Description { get; set; }

        [Required]
        public string Ingredients { get; set; }

        [Required]
        public int Type { get; set; }
    }
}