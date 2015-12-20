namespace TheMealDeal.Models
{
    using Common.Constants;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Recipe
    {
        private string title;
        private string description;
        private ICollection<Ingredient> ingredients;
        private Type type;
        private int matchProcentage;

        public Recipe()
        {
            this.ingredients = new List<Ingredient>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(ValidationConstants.RecipeTitleMaxLenght)]
        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }
         
        [Required]
        [MinLength(ValidationConstants.RecipeDescriptionMinLength)]
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        [Required]
        public ICollection<Ingredient> Ingredients
        {
            get { return this.ingredients; }
            set { this.ingredients = value; }
        }

        [Required]
        public Type Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public int MatchProcentage
        {
            get { return this.matchProcentage; }
            set { this.matchProcentage = value; }
        }

        public string UserId { get; set; }
    }
}
