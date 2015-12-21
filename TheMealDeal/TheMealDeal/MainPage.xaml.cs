namespace TheMealDeal
{
    using System.IO;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Controls;
    using TheMealDeal.Pages;
    using Windows.UI.Xaml.Navigation;

    public sealed partial class MainPage : Page
    {
        
        private string path;

        SQLite.Net.SQLiteConnection connection;

        public MainPage()
        {
            this.InitializeComponent();
            this.path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "db.sqlite");
            this.connection = new SQLite.Net.SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), path);
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void BrowseButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(BrowsePage));
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SearchByIngredientsPage));
        }

        private void FavButotn_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(FavouritesPage));
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AddRecipePage));
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
