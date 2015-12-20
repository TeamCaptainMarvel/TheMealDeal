namespace TheMealDeal.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Ingredient
    {
        public Ingredient(string name)
        {
            this.Name = name;
        }

        public Ingredient()
        {

        }

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int RecipeId { get; set; }
    }
}
