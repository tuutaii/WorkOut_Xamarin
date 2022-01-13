using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WorkOutApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorkOutApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        Services.Service _service = new Services.Service();
        public LoginPage()
        {
            InitializeComponent();
        }
        private async void cmdSigup_from_login_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SignUpPage());
        }

        private async  void cmdLogin_Clicked(object sender, EventArgs e)
        {
          
             if (entryEmail.Text == null || entryPassword.Text == null )
            {
                DisplayAlert("Notification", "Vui lòng nhập đầy đủ thông tin", "OK");
            }         
            else
            {
                var response = _service.LogInUser(entryEmail.Text, entryPassword.Text);
                if (string.IsNullOrEmpty(await response))
                {
                    DisplayAlert("Notification", "Đăng nhập thất bại", "OK");
                }
                else
                {
                    DisplayAlert("Notification", "Đăng nhập thành công", "OK");
                    Navigation.PushAsync(new HomeTabbedPage());

                }
            }           
        }
    }
}