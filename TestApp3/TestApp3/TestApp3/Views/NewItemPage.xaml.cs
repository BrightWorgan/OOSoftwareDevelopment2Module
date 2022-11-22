using System;
using System.Collections.Generic;
using System.ComponentModel;
using TestApp3.Models;
using TestApp3.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestApp3.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}