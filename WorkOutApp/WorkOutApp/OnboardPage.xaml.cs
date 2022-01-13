using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorkOutApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OnboardPage : ContentPage
    {
        public OnboardPage()
        {
            InitializeComponent();
        }

        private void cmdStart_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginPage());
        }

        private void cmdStart_onboard_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginPage());

        }

        private void cmdSignUp_onboard_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SignUpPage());
        }
    }
}