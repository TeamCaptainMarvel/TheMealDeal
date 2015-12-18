namespace TheMealDeal.ViewModels
{
    using System.Collections.Generic;

    public class BrowseViewModel
    {
        public IEnumerable<RecipeViewModel> Recipes { get; set; }

        public BrowseViewModel()
        {
            this.Recipes = new RecipeViewModel[]
            {
                new RecipeViewModel(title: "Sandwitch",
                description: "take two slices of bread, put smth on them, eat them",
                type: "meat", ingredients: new List<string> { "bread", "butter", "ham", "tomato"}),
                new RecipeViewModel(title: "Sandwitch2",
                description: "take two slices of bread, put smth on them, eat them",
                type: "meat", ingredients: new List<string> { "bread", "butter", "ham", "tomato"}),
                new RecipeViewModel(title: "Sandwitch3",
                description: "take two slices of bread, put smth on them, eat them",
                type: "meat", ingredients: new List<string> { "bread", "butter", "ham", "tomato"}),
                new RecipeViewModel(title: "Sandwitch4",
                description: "take two slices of bread, put smth on them, eat them",
                type: "meat", ingredients: new List<string> { "bread", "butter", "ham", "tomato"}),
                new RecipeViewModel(title: "Sandwitch5",
                description: "take two slices of bread, put smth on them, eat them",
                type: "meat", ingredients: new List<string> { "bread", "butter", "ham", "tomato"})
            };
        }
    }
}
