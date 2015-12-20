namespace TheMealDeal.Pages
{
    using Windows.UI.Xaml.Controls;
    using TheMealDeal.ViewModels;
    using Windows.UI.Xaml.Navigation;

    public sealed partial class RecipePage : Page
    {

        public RecipePage()
        {
            this.InitializeComponent();
            this.DataContext = new RecipeViewModel()
            {
                Title= "Roast Pork and Pickled Cucumber Sandwich",
                Description = "Make quick pickles by combining cucumber, vinegar, oil, brown sugar, salt, and pepper; they give the sandwich an extra zing.",
                Method= "Heat oven to 450° F. Season the pork with the cayenne and ¼ teaspoon salt. Roast on a rimmed baking sheet until an instant-read thermometer inserted in the center reaches 145° F, 20 to 25 minutes; thinly slice. Meanwhile, combine the cucumber, vinegar, oil, brown sugar, and ¼ teaspoon each salt and black pepper in a medium bowl. Divide the mayonnaise, pork, and cucumber among the rolls.",
                Ingredients = "1 pound boneless pork loin, 1/2 teaspoon cayenne pepper, kosher salt and black pepper, cucumber - thinly sliced, 3 tablespoons cider vinegar, 2 tablespoons olive oil, 2 teaspoons brown sugar, 1/3 cup mayonnaise, 4 Portuguese rolls, split",
                Type= "meat",
                ImageUrl= "http://cdn-image.realsimple.com/sites/default/files/styles/rs_main_image/public/image/images/1309/pork-cucumber_300.jpg?itok=8KJ2fakx"
            };
        }

        protected override void OnNavigatedTo(NavigationEventArgs recipe)
        {
            ShowStoryboard.Begin();
        }
    }
}
