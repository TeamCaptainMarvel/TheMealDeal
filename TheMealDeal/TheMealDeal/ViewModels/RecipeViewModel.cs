using SQLite.Net.Attributes;
namespace TheMealDeal.ViewModels
{
    using Commands;
    using System.Collections.Generic;
    using System.Windows.Input;
    using System;

    public class RecipeViewModel : BaseViewModel
    {
        private string title;
        private string ingredients;
        private string description;
        private string method;
        private string type;
        private string imageUrl;
        private bool ingredientsVisible;
        private bool buttonsVisible;
        private bool methodVisible;
        private ICommand showIngredients;
        private ICommand showButtons;
        private ICommand showMethod;


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

        public string Method
        {
            get { return this.method; }
            set
            {
                this.method = value;
                this.OnPropertyChanged("Method");
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

        public bool IngredientsVisible
        {
            get { return this.ingredientsVisible; }
            set
            {
                this.ingredientsVisible = value;
                this.OnPropertyChanged("IngredientsVisible");
            }
        }

        public bool ButtonsVisible
        {
            get { return this.buttonsVisible; }
            set
            {
                this.buttonsVisible = value;
                this.OnPropertyChanged("ButtonsVisible");
            }
        }

        public bool MethodVisible
        {
            get { return this.methodVisible; }
            set
            {
                this.methodVisible = value;
                this.OnPropertyChanged("MethodVisible");
            }
        }

        public ICommand ShowMethod
        {
            get
            {
                if (this.showMethod == null)
                {
                    this.showMethod = new DelegateCommand(this.MethodShow);
                }
                return this.showMethod;
            }
        }

        public ICommand ShowIngredients
        {
            get
            {
                if (this.showIngredients == null)
                {
                    this.showIngredients = new DelegateCommand(this.IngredientsShow);
                }
                return this.showIngredients;
            }
        }

        public ICommand ShowButtons
        {
            get
            {
                if (this.showButtons == null)
                {
                    this.showButtons = new DelegateCommand(this.ButtonsShow);
                }
                return this.showButtons;
            }
        }

        private void IngredientsShow()
        {
            this.HideAll();
            this.IngredientsVisible = true;
        }

        private void MethodShow()
        {
            this.HideAll();
            this.MethodVisible = true;
        }

        private void ButtonsShow()
        {
            this.HideAll();
            this.ButtonsVisible = true;
        }

        private void HideAll()
        {
            this.MethodVisible = false;
            this.IngredientsVisible = false;
            this.ButtonsVisible = false;
        }

        public RecipeViewModel()
        {
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
