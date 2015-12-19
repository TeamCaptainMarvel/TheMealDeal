namespace TheMealDeal.Views
{
    using ViewModels;
    using Windows.UI.Xaml.Controls;

    public sealed partial class RecipesView : UserControl
    {
        public RecipesView()
        {
            this.InitializeComponent();
            this.DataContext = new RecipesViewModel();
        }
    }
}
