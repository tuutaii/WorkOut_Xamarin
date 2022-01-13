using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using WorkOutApp.Services;
using Xamarin.Forms;

namespace WorkOutApp.ViewModels
{
    public  class LoginViewModel
    {
        private Service _apiservices = new Service();
        public string Username { get; set; }
        public string Password { get; set; }
        public ICommand LoginCommand
        {
            get
            {
                return new Command(async () =>
                {
                    await _apiservices.LogInUser(Username, Password);
                });
            }
        }
    }
}
