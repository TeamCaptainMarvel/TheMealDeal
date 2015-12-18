﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using TheMealDeal.ViewModels;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace TheMealDeal
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AddRecipePage : Page
    {
        

        public AddRecipePage()
        {
            this.InitializeComponent();

            Recipe newRecipe = new Recipe
            {
                Title = titleBox.Text,
                Description = descriptionBox.Text,
                //get ingredients
                //get radio button value with mvvm and binding
                //http://wpftutorial.net/RadioButton.html

            };
            //ADD the recipe to a base :D
        }
    }
}
