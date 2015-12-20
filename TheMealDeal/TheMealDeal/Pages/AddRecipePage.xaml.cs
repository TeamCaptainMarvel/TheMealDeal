namespace TheMealDeal
{
    using Windows.UI.Xaml.Controls;
    using Windows.UI.Xaml;
    using ViewModels;
    using Pages;

    public sealed partial class AddRecipePage : Page
    {
        private string mealType;

        public AddRecipePage()
        {
            this.InitializeComponent();
        }

        private void AddRecipe_Click(object sender, RoutedEventArgs e)
        {
            RecipeViewModel newRecipe = new RecipeViewModel()
            {
                Title = titleBox.Text,
                Description = descriptionBox.Text,
                Ingredients = ingredientsBlock.Text,
                Type = mealType
            };
            //TODO: Add the recipe somewhere
            Frame.Navigate(typeof(RecipePage));
        }

        private void vegeterian_Checked(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            mealType = "vegeterian";
        }

        private void meat_Checked(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            mealType = "meat";
        }

        private void vegan_Checked(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            mealType = "vegan";
        }


    }
}
