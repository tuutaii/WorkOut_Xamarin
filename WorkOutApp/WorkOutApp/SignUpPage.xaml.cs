using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using WorkOutApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorkOutApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage()
        {
            InitializeComponent();
        }

        private void cmdSigup_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginPage());
        }
        private void signIn_Clicked(object sender, EventArgs e)
        {
            if (entryEmail.Text == null || entryPassword.Text == null || entryUsername.Text == null || entryConfirmPassword.Text == null)
            {
                DisplayAlert("Notification", "Vui lòng nhập đầy đủ thông tin", "OK");

            }
            else if (entryPassword.Text.Length <6)
            {
                DisplayAlert("Notification", "Mật khẩu tối đa 6 ký tự. Bao gồm chữ Hoa, Thường, Số, Ký tự đặc biệt.", "OK");
            }
            else if (entryConfirmPassword.Text != entryPassword.Text)
            {
                DisplayAlert("Notification", "Confirm Password phải giống với Password.", "OK");
            }
            else
            {
                var Respone = RegisterUser(entryEmail.Text, entryPassword.Text, entryConfirmPassword.Text);
                if (Respone == true)
                {
                    DisplayAlert("Notification", "Đăng ký thành công", "OK");
                    Navigation.PushAsync(new LoginPage());
                }
                else
                {
                    DisplayAlert("Notification", "Đăng ký thất bại", "OK");
                }
            }           
        }
        public bool RegisterUser(string email, string password, string confirmPassword)
        {
            bool Respone = false;

            var client = new HttpClient();

            var model = new RegisterBindingModel
            {
                Email = email,
                Password = password,
                ConfirmPassword = confirmPassword,
            };

            var json = JsonConvert.SerializeObject(model);
            HttpContent httpContent = new StringContent(json);
            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var respone = client.PostAsync("http://192.168.1.10/WebAPI_Auth/api/Account/Register", httpContent);

            var mystring = respone.GetAwaiter().GetResult();

            if(respone.Result.IsSuccessStatusCode)
            {
                Respone = true;
                
            }
            return Respone;
           
        }
    }
}