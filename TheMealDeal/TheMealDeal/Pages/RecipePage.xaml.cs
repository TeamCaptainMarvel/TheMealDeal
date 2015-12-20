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
            this.DataContext = new RecipeViewModel();
        }

        protected override void OnNavigatedTo(NavigationEventArgs recipe)
        {

            ShowStoryboard.Begin();
        }
    }
}
