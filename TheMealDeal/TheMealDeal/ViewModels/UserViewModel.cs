namespace TheMealDeal.ViewModels
{
    public class UserViewModel : BaseViewModel
    {
        private string username;
        private string imageUrl;


        public string Username
        {
            get { return this.username; }
            set
            {
                this.username = value;
                this.OnPropertyChanged("Username");
            }
        }

        public string ImageUrl
        {
            get { return this.imageUrl; }
            set
            {
                this.username = value;
                this.OnPropertyChanged("ImageUrl");
            }
        }

        public static UserViewModel FromUser(UserViewModel user)
        {
            return new UserViewModel
            {
                Username = user.Username
            };
        }
    }
}
