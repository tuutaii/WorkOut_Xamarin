using System;
using WorkOutApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorkOutApp
{
    public partial class App : Application
    {   

        public App()
        {
            InitializeComponent();     
            MainPage = new NavigationPage(new OnboardPage());

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
