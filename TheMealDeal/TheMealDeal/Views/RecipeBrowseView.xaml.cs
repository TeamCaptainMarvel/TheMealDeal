namespace TheMealDeal.Views
{
    using TheMealDeal.ViewModels;
    using Windows.UI.Xaml.Controls;

    public sealed partial class RecipeBrowseView : UserControl
    {
        public RecipeBrowseView()
        {
            this.InitializeComponent();
            this.DataContext = new BrowseViewModel();
        }
    }
}
