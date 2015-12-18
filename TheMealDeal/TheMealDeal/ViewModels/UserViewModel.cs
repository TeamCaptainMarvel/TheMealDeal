using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMealDeal.ViewModels
{
    public class UserViewModel : BaseViewModel
    {
        private string username;
        private string password;
        private string imgUrl;

        public string Username
        {
            get { return this.username; }
            set
            {
                this.username = value;
                this.OnPropertyChanged("Username");
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
