namespace TheMealDeal.ViewModels
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using TheMealDeal.Extensions;

    public class RecipesViewModel
    {
        private ObservableCollection<RecipeViewModel> vegeterianRecipes;
        private ObservableCollection<RecipeViewModel> veganRecipes;
        private ObservableCollection<RecipeViewModel> meatRecipes;

        public IEnumerable<RecipeViewModel> VegeterianRecipes
        {
            get { return this.vegeterianRecipes; }
            set
            {
                if(this.vegeterianRecipes == null)
                {
                    this.vegeterianRecipes = new ObservableCollection<RecipeViewModel>();
                }
                this.vegeterianRecipes.Clear();
                this.vegeterianRecipes.AddRange(value);
            }
        }
        public IEnumerable<RecipeViewModel> VeganRecipes
        {
            get { return this.veganRecipes; }
            set
            {
                if (this.veganRecipes == null)
                {
                    this.veganRecipes = new ObservableCollection<RecipeViewModel>();
                }
                this.veganRecipes.Clear();
                this.veganRecipes.AddRange(value);
            }
        }
        public IEnumerable<RecipeViewModel> MeatRecipes
        {
            get { return this.meatRecipes; }
            set
            {
                if (this.meatRecipes == null)
                {
                    this.meatRecipes = new ObservableCollection<RecipeViewModel>();
                }
                this.meatRecipes.Clear();
                this.meatRecipes.AddRange(value);
            }
        }
        /// <summary>
        /// Make like pavkata userDBVM
        /// </summary>
        public RecipesViewModel()
        {
            this.VegeterianRecipes = new RecipeViewModel[]
            {
                new RecipeViewModel(
                    title: "Beets, Spinach, and Goat Cheese Sandwich",
                    description: "Mild, creamy goat cheese pairs well with the sweet roasted beets and raisins.",
                    type: "vegeterian",
                    ingredients: "beets, olive oil, spinach, tomato, goat cheese",
                    imageUrl:"http://cdn-image.realsimple.com/sites/default/files/styles/rs_main_image/public/image/images/1309/beet-spinach_300.jpg?itok=Y_Yp8_uY"),
                new RecipeViewModel(
                    title: "Corn Salad with Parmesan and Chiles",
                    description: "The only thing better than corn on the cob? This fresh corn salad that’s much easier to eat.",
                    type: "vegeterian",
                    ingredients: "bread, butter, ham, tomato",
                    imageUrl:"http://cdn-image.realsimple.com/sites/default/files/styles/rs_photo_gallery_vert/public/1435698964/corn-salad-parmesan.jpg?itok=R3nEY1Oz"),
                new RecipeViewModel(
                    title: "Arugula, Peach, and Cheddar Salad",
                    description: "Peaches and cheddar may sound like an odd combination, but the sweet, fragrant fruit perfectly complements the sharp cheese.",
                    type: "vegeterian",
                    ingredients:"bread, butter, ham, tomato",
                    imageUrl:"http://cdn-image.realsimple.com/sites/default/files/styles/rs_photo_gallery_vert/public/1435698964/arugula-peach-cheddar.jpg?itok=fz-KX7Hz"),
                new RecipeViewModel(
                    title: "Best Vegetarian Stuffing",
                    description: "You don't need sausage to make this Thanksgiving side dish shine.",
                    type: "vegeterian",
                    ingredients: "bread, butter, ham, tomato",
                    imageUrl:"http://cdn-image.realsimple.com/sites/default/files/styles/rs_main_image/public/veg-stuffing.jpg?itok=S9P-QqlE"),
                new RecipeViewModel(
                    title: "Creamy Eggplant and Feta Dip",
                    description: "To make this version of baba ganoush, a classic Middle Eastern spread, roast eggplant until tender and mix with Feta, parsley, lemon, and tahini.",
                    type: "vegeterian",
                    ingredients: "bread, butter, ham, tomato"),
                new RecipeViewModel(
                    title: "Marinated Mushrooms",
                    description: "You can make these mushrooms several days in advance—the flavor gets better the longer they sit.",
                    type: "vegeterian",
                    ingredients: "bread, butter, ham, tomato"),
                new RecipeViewModel(
                    title: "Potted Cheese Dip",
                    description: "Use port, sherry, or balsamic vinegar in this dip to add a slightly sweet yet acidic tang.",
                    type: "vegeterian",
                    ingredients: "bread, butter, ham, tomato"),
                new RecipeViewModel(
                    title: "Goat Cheese Bruschetta",
                    description: "It’s the vinaigrette—with balsamic vinegar, honey, shallots, and fresh herbs—that makes this dish sing.",
                    type: "vegeterian",
                    ingredients: "bread, butter, ham, tomato",
                    imageUrl:"http://cdn-image.realsimple.com/sites/default/files/styles/rs_photo_gallery_vert/public/image/images/food-recipes/recipe-collections/0705/goat-cheese-bruschetta_gal.jpg?itok=Km1HuOhq"),
                new RecipeViewModel(
                    title: "Chilaquiles",
                    description: "Crispy tortillas meet enchilada sauce, Feta, onion, and cilantro in this gourmet take on nachos.",
                    type: "vegeterian",
                    ingredients: "bread, butter, ham, tomato",
                    imageUrl:"http://cdn-image.realsimple.com/sites/default/files/styles/rs_photo_gallery_horz/public/image/images/1110/chlaqules-tortilla_gal.jpg?itok=Ifz2LePK")
            };

            this.VeganRecipes = new RecipeViewModel[]
            {
                new RecipeViewModel(
                    title: "Romesco Sauce",
                    description: "to Dress Up Grilled Eggplant",
                    type: "vegan",
                    ingredients:"bread, butter, ham, tomato",
                    imageUrl:"http://www.solutionstalk.com/home/wp-content/uploads/bigstock-club-sandwich-clubhouse-Sand-26008286.jpg"),
                new RecipeViewModel(
                    title: "Grilled Potato and Onion Salad",
                    description: "Grilling onions brings out a sweetness that pairs perfectly with the smoky char of grilled potatoes. Flat-leaf parsley adds a burst of fresh flavor, while balsamic vinegar gives the dish a touch of tang.",
                    type: "vegan",
                    ingredients: "red potato, onion, olive oil, vinegar, salt, pepper",
                    imageUrl:"http://cdn-image.realsimple.com/sites/default/files/styles/rs_main_image/public/image/images/food-recipes/recipe-collections/0806/grilled-potato_300.jpg?itok=aOOuBRZA"),
                new RecipeViewModel(
                    title: "Watercress, Beet, and Fennel Salad",
                    description: "A tangy buttermilk dressing mixed with a variety of fresh herbs complements earthy beets and fennel in this fresh market salad.",
                    type: "vegan",
                    ingredients: "bread, butter, ham, tomato",
                    imageUrl:"http://cdn-image.realsimple.com/sites/default/files/styles/rs_photo_gallery_vert/public/1435698964/watercress-beet-fennel.jpg?itok=XKdQcLHR"),
                new RecipeViewModel(
                    title: "Quinoa and Vegetable Salad with Tahini Dressing",
                    description: "Made with fresh ginger, lemon juice and a drizzle of honey, the creamy tahini dressing steals the show in this salad.",
                    type: "vegan",
                    ingredients: "bread, butter, ham, tomato"
                    ,imageUrl:"http://cdn-image.realsimple.com/sites/default/files/styles/rs_photo_gallery_vert/public/1435698964/quinoa-vegetable-salad.jpg?itok=IzZH054a"),
            };
            this.MeatRecipes = new RecipeViewModel[]
            {
                new RecipeViewModel(
                    title: "Smoked Salmon Salad Sandwich",
                    description: "Mix freshly roasted salmon with smoked salmon for a delicious filling that’s not overpowering. Bonus: The salmon mixture can be made up to 3 days in advance.",
                    type: "meat",
                    ingredients:"salmnon fillet, smoked salmon, mayonnaise, celery, black pepper, lettuce leaves",
                    imageUrl:"http://cdn-image.realsimple.com/sites/default/files/styles/rs_main_image/public/image/images/1309/salmon-salad_300.jpg?itok=pN_GDyW-"),
                new RecipeViewModel(
                    title: "Tomato, Bacon, and Garlic Mayo Sandwich",
                    description: "Upgrade a standard BLT with a garlicky yogurt sauce and sliced avocado.",
                    type: "meat",
                    ingredients: "bacon, yogurt, avocado, tomato, kosher salt",
                    imageUrl:"http://cdn-image.realsimple.com/sites/default/files/styles/rs_main_image/public/image/images/1309/tomato-bacon_300.jpg?itok=V-UV_e8q"),
                new RecipeViewModel(
                    title: "Turkey Pot Pie",
                    description: "This is a fun way to use up a variety of Thanksgiving leftovers.",
                    type: "meat",
                    ingredients: "bread, butter, ham, tomato",
                    imageUrl: "http://cdn-image.realsimple.com/sites/default/files/styles/rs_photo_gallery_vert/public/turkey-pot-pie.jpg?itok=pCQBozCE"),
                new RecipeViewModel(
                    title: "Pasta With Tuna and Black Olive Vinaigrette",
                    description: "Briny capers, kalamata olives, and fresh lemon juice add zip to a simple salad of canned tuna and pasta. Use whole-wheat rigatoni or penne for a hearty, health-conscious option.",
                    type: "meat",
                    ingredients: "bread, butter, ham, tomato",
                    imageUrl:"http://cdn-image.realsimple.com/sites/default/files/styles/rs_photo_gallery_vert/public/1435698964/pasta-tuna-olive.jpg?itok=pNXI_2dJ"),
            };
        }
    }
}
