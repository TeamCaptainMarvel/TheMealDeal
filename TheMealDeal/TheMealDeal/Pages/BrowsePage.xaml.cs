﻿namespace TheMealDeal.Pages
{
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Controls;
    using ViewModels;

    public sealed partial class BrowsePage : Page
    {
        public BrowsePage()
        {
            this.InitializeComponent();
            this.DataContext = new BrowseViewModel();
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}