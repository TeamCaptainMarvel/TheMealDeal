namespace TheMealDeal.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Recipe
    {

        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
         
        public string Description { get; set; }

        public IList<string> Ingredients { get; set; }

        public User AddedBy { get; set; }
    }
}
