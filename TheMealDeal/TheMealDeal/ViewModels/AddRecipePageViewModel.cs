namespace TheMealDeal.ViewModels
{
    public class AddRecipePageViewModel : BaseViewModel
    {
        private string selectedContent;

        public string SelectedContent
        {
            get { return this.selectedContent; }
            set
            {
                this.selectedContent = value;
                this.OnPropertyChanged("SelectedContent");
            }
        }
    }
}
