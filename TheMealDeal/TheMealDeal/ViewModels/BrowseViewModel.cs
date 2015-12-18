namespace TheMealDeal.ViewModels
{
    using System.Collections.Generic;

    public class BrowseViewModel
    {
        //3 collections for the 3 types of recipes
        public IEnumerable<RecipeViewModel> Recipes { get; set; }

        public BrowseViewModel()
        {
            this.Recipes = new RecipeViewModel[]
            {
                new RecipeViewModel(
                    title: "Sandwitch",
                    description: "take two slices of bread, put smth on them, stick them together, make the text muuuuuuuuuuuuch larger and even more larger and more more more more ahhaj djkhadfkjsadhf eat them",
                    type: "meat",
                    ingredients: "bread, butter, ham, tomato",
                    imageUrl:"http://blogs.plos.org/obesitypanacea/files/2014/10/sandwich.jpg"),
                new RecipeViewModel(
                    title: "Sandwitch2",
                    description: "take two slices of bread, put smth on them, eat them",
                    type: "meat",
                    ingredients: "bread, butter, ham, tomato",
                    imageUrl:"http://blogs.plos.org/obesitypanacea/files/2014/10/sandwich.jpg"),
                new RecipeViewModel(
                    title: "Sandwitch3",
                    description: "take two slices of bread, put smth on them, eat them",
                    type: "meat",
                    ingredients:"bread, butter, ham, tomato",
                    imageUrl:"http://www.solutionstalk.com/home/wp-content/uploads/bigstock-club-sandwich-clubhouse-Sand-26008286.jpg"),
                new RecipeViewModel(
                    title: "Sandwitch4",
                    description: "take two slices of bread, put smth on them, eat them",
                    type: "meat",
                    ingredients: "bread, butter, ham, tomato",
                    imageUrl:"http://globe-views.com/dcim/dreams/sandwich/sandwich-01.jpg"),
                new RecipeViewModel(
                    title: "Sandwitch5",
                    description: "take two slices of bread, put smth on them, eat them",
                    type: "meat",
                    ingredients: "bread, butter, ham, tomato"),
                new RecipeViewModel(
                    title: "Sandwitch6",
                    description: "take two slices of bread, put smth on them, eat them",
                    type: "meat",
                    ingredients: "bread, butter, ham, tomato"),
                new RecipeViewModel(
                    title: "Sandwitch7",
                    description: "take two slices of bread, put smth on them, eat them",
                    type: "meat",
                    ingredients: "bread, butter, ham, tomato"),
                new RecipeViewModel(
                    title: "Sandwitch8",
                    description: "take two slices of bread, put smth on them, eat them",
                    type: "meat",
                    ingredients: "bread, butter, ham, tomato"),
                new RecipeViewModel(
                    title: "Sandwitch9",
                    description: "take two slices of bread, put smth on them, eat them",
                    type: "meat",
                    ingredients: "bread, butter, ham, tomato"),
                new RecipeViewModel(
                    title: "Sandwitch10",
                    description: "take two slices of bread, put smth on them, eat them",
                    type: "meat",
                    ingredients: "bread, butter, ham, tomato"),
                new RecipeViewModel(
                    title: "Sandwitch20",
                    description: "take two slices of bread, put smth on them, eat them",
                    type: "meat",
                    ingredients: "bread, butter, ham, tomato")
            };
        }
    }
}
