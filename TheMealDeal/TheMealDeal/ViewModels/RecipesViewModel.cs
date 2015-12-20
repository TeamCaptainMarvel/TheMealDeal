﻿namespace TheMealDeal.ViewModels
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using TheMealDeal.Extensions;

    public class RecipesViewModel
    {
        private ObservableCollection<RecipeViewModel> vegeterianRecipes;
        private ObservableCollection<RecipeViewModel> veganRecipes;
        private ObservableCollection<RecipeViewModel> meatRecipes;

        public IEnumerable<RecipeViewModel> VegeterianRecipes
        {
            get { return this.vegeterianRecipes; }
            set
            {
                if(this.vegeterianRecipes == null)
                {
                    this.vegeterianRecipes = new ObservableCollection<RecipeViewModel>();
                }
                this.vegeterianRecipes.Clear();
                this.vegeterianRecipes.AddRange(value);
            }
        }
        public IEnumerable<RecipeViewModel> VeganRecipes
        {
            get { return this.veganRecipes; }
            set
            {
                if (this.veganRecipes == null)
                {
                    this.veganRecipes = new ObservableCollection<RecipeViewModel>();
                }
                this.veganRecipes.Clear();
                this.veganRecipes.AddRange(value);
            }
        }
        public IEnumerable<RecipeViewModel> MeatRecipes
        {
            get { return this.meatRecipes; }
            set
            {
                if (this.meatRecipes == null)
                {
                    this.meatRecipes = new ObservableCollection<RecipeViewModel>();
                }
                this.meatRecipes.Clear();
                this.meatRecipes.AddRange(value);
            }
        }
        /// <summary>
        /// Make like pavkata userDBVM
        /// </summary>
        public RecipesViewModel()
        {
            this.VegeterianRecipes = new RecipeViewModel[]
            {
                new RecipeViewModel(
                    title: "Sandwitch",
                    description: "take two slices of bread, put smth on them, stick them together, make the text muuuuuuuuuuuuch larger and even more larger and more more more more ahhaj djkhadfkjsadhf eat them",
                    type: "meat",
                    ingredients: "bread, butter, ham, tomato",
                    imageUrl:"http://blogs.plos.org/obesitypanacea/files/2014/10/sandwich.jpg"),
                new RecipeViewModel(
                    title: "Sandwitch2",
                    description: "take two slices of bread, put smth on them, eat them",
                    type: "meat",
                    ingredients: "bread, butter, ham, tomato",
                    imageUrl:"http://blogs.plos.org/obesitypanacea/files/2014/10/sandwich.jpg"),
                new RecipeViewModel(
                    title: "Sandwitch3",
                    description: "take two slices of bread, put smth on them, eat them",
                    type: "meat",
                    ingredients:"bread, butter, ham, tomato",
                    imageUrl:"http://www.solutionstalk.com/home/wp-content/uploads/bigstock-club-sandwich-clubhouse-Sand-26008286.jpg"),
                new RecipeViewModel(
                    title: "Sandwitch4",
                    description: "take two slices of bread, put smth on them, eat them",
                    type: "meat",
                    ingredients: "bread, butter, ham, tomato",
                    imageUrl:"http://globe-views.com/dcim/dreams/sandwich/sandwich-01.jpg"),
                new RecipeViewModel(
                    title: "Sandwitch5",
                    description: "take two slices of bread, put smth on them, eat them",
                    type: "meat",
                    ingredients: "bread, butter, ham, tomato"),
                new RecipeViewModel(
                    title: "Sandwitch6",
                    description: "take two slices of bread, put smth on them, eat them",
                    type: "meat",
                    ingredients: "bread, butter, ham, tomato"),
                new RecipeViewModel(
                    title: "Sandwitch7",
                    description: "take two slices of bread, put smth on them, eat them",
                    type: "meat",
                    ingredients: "bread, butter, ham, tomato"),
                new RecipeViewModel(
                    title: "Sandwitch8",
                    description: "take two slices of bread, put smth on them, eat them",
                    type: "meat",
                    ingredients: "bread, butter, ham, tomato"),
                new RecipeViewModel(
                    title: "Sandwitch9",
                    description: "take two slices of bread, put smth on them, eat them",
                    type: "meat",
                    ingredients: "bread, butter, ham, tomato"),
                new RecipeViewModel(
                    title: "Sandwitch10",
                    description: "take two slices of bread, put smth on them, eat them",
                    type: "meat",
                    ingredients: "bread, butter, ham, tomato"),
                new RecipeViewModel(
                    title: "Sandwitch20",
                    description: "take two slices of bread, put smth on them, eat them",
                    type: "meat",
                    ingredients: "bread, butter, ham, tomato")
            };

            this.VeganRecipes = new RecipeViewModel[]
            {
                new RecipeViewModel(
                    title: "Sandwitch3",
                    description: "take two slices of bread, put smth on them, eat them",
                    type: "meat",
                    ingredients:"bread, butter, ham, tomato",
                    imageUrl:"http://www.solutionstalk.com/home/wp-content/uploads/bigstock-club-sandwich-clubhouse-Sand-26008286.jpg"),
                new RecipeViewModel(
                    title: "Sandwitch4",
                    description: "take two slices of bread, put smth on them, eat them",
                    type: "meat",
                    ingredients: "bread, butter, ham, tomato",
                    imageUrl:"http://globe-views.com/dcim/dreams/sandwich/sandwich-01.jpg"),
                new RecipeViewModel(
                    title: "Sandwitch5",
                    description: "take two slices of bread, put smth on them, eat them",
                    type: "meat",
                    ingredients: "bread, butter, ham, tomato"),
                new RecipeViewModel(
                    title: "Sandwitch6",
                    description: "take two slices of bread, put smth on them, eat them",
                    type: "meat",
                    ingredients: "bread, butter, ham, tomato"),
            };
            this.MeatRecipes = new RecipeViewModel[]
            {
                new RecipeViewModel(
                    title: "Sandwitch3",
                    description: "take two slices of bread, put smth on them, eat them",
                    type: "meat",
                    ingredients:"bread, butter, ham, tomato",
                    imageUrl:"http://www.solutionstalk.com/home/wp-content/uploads/bigstock-club-sandwich-clubhouse-Sand-26008286.jpg"),
                new RecipeViewModel(
                    title: "Sandwitch4",
                    description: "take two slices of bread, put smth on them, eat them",
                    type: "meat",
                    ingredients: "bread, butter, ham, tomato",
                    imageUrl:"http://globe-views.com/dcim/dreams/sandwich/sandwich-01.jpg"),
                new RecipeViewModel(
                    title: "Sandwitch5",
                    description: "take two slices of bread, put smth on them, eat them",
                    type: "meat",
                    ingredients: "bread, butter, ham, tomato"),
                new RecipeViewModel(
                    title: "Sandwitch6",
                    description: "take two slices of bread, put smth on them, eat them",
                    type: "meat",
                    ingredients: "bread, butter, ham, tomato"),
            };
        }
    }
}
