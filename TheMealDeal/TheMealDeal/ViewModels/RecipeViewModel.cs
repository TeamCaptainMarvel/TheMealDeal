using SQLite.Net.Attributes;
namespace TheMealDeal.ViewModels
{
    using System.Collections.Generic;

    public class RecipeViewModel : BaseViewModel
    {
        private string title;
        private string ingredients;
        private string description;
        private string type;
        private string imageUrl;

        public string Title
        {
            get { return this.title; }
            set
            {
                this.title = value;
                this.OnPropertyChanged("Title");
            }
        }

        public string Ingredients
        {
            get { return this.ingredients; }
            set
            {
                this.ingredients = value;
                this.OnPropertyChanged("Ingredients");
            }
        }

        public string Description
        {
            get { return this.description; }
            set
            {
                this.description = value;
                this.OnPropertyChanged("Description");
            }
        }

        public string Type
        {
            get { return this.type; }
            set
            {
                this.type = value;
                this.OnPropertyChanged("Type");
            }
        }

        public string ImageUrl
        {
            get { return this.imageUrl; }
            set
            {
                this.imageUrl = value;
                this.OnPropertyChanged("ImageUrl");
            }
        }

        public RecipeViewModel(string title, string description, string ingredients, string type, string imageUrl = "http://prikachi.com/images/495/8523495D.png")
        {
            this.Title = title;
            this.Description = description;
            this.Ingredients = ingredients;
            this.Type = type;
            this.ImageUrl = imageUrl;
        }
    }
}
