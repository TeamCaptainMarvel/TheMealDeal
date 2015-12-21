namespace TheMealDeal.Pages
{
    using Windows.UI.Xaml.Controls;

    public sealed partial class SearchByIngredientsPage : Page
    {
        public SearchByIngredientsPage()
        {
            this.InitializeComponent();
        }

        private void SearchButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            Frame.Navigate(typeof(RecipePage));
        }
    }
}
