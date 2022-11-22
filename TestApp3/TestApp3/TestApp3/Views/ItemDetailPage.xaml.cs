using System.ComponentModel;
using TestApp3.ViewModels;
using Xamarin.Forms;

namespace TestApp3.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}