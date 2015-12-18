using SQLite.Net.Attributes;
namespace TheMealDeal.ViewModels
{
    using System.Collections.Generic;

    public class RecipeViewModel : BaseViewModel
    {
        private string title;
        private IEnumerable<string> ingredients;
        private string description;
        private string type;

        public string Title
        {
            get { return this.title; }
            set
            {
                this.title = value;
                this.OnPropertyChanged("Title");
            }
        }

        public IEnumerable<string> Ingredients
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

        public RecipeViewModel(string title, string description, List<string> ingredients, string type)
        {
            this.Title = title;
            this.Description = description;
            this.Ingredients = ingredients;
            this.Type = type;
        }
    }
}
