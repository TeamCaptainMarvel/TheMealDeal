namespace TheMealDeal.ViewModels
{
    using System.ComponentModel;

    public class BaseViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propName)
        {
            if(this.PropertyChanged == null)
            {
                return;
            }
            var propEventArgs = new PropertyChangedEventArgs(propName);
            this.PropertyChanged.Invoke(this, propEventArgs);
        }
    }
}
