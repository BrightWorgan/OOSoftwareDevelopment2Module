using System;
using TestApp3.Services;
using TestApp3.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestApp3
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
