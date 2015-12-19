namespace TheMealDeal.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Recipe
    {
        private string title;
        private string description;
        private IList<string> ingredients;
        private Type type;

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(35)]
        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }
         
        [Required]
        [MaxLength(200)]
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        [Required]
        public IList<string> Ingredients
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

        public string UserId { get; set; }
    }
}
