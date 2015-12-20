namespace TheMealDeal.Pages
{
    using Windows.UI.Xaml.Controls;
    using TheMealDeal.ViewModels;
    using Windows.UI.Xaml.Navigation;

    public sealed partial class RecipePage : Page
    {
        public RecipePage(RecipeViewModel viewModel)
        {
            this.InitializeComponent();
            this.ViewModel = viewModel;
        }

        public RecipeViewModel ViewModel
        {
            get { return this.DataContext as RecipeViewModel; }
            set { this.DataContext = value; }
        }

        protected override void OnNavigatedTo(NavigationEventArgs recipe)
        {
            ShowStoryboard.Begin();
        }
    }
}
