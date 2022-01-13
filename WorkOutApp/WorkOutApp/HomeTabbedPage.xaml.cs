using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    public partial class HomeTabbedPage : TabbedPage
    {
        public HomeTabbedPage()
        {
            InitializeComponent();
            ListViewInit();

        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            var navigationPage = Application.Current.MainPage as NavigationPage;
            navigationPage.BarBackgroundColor = Color.FromHex("#d8202c");
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            var navigationPage = Application.Current.MainPage as NavigationPage;
            navigationPage.BarBackgroundColor = Color.FromHex("#d8202c");
        }

        async void ListViewInit()
        {
            List<TabbedPageModel> dscn = new List<TabbedPageModel>();
            dscn.Add(new TabbedPageModel
            {
                Tenchucnang = "DS BÀI TẬP",
                Trang = typeof(AllExercicesPage),
  
            }); ;
            dscn.Add(new TabbedPageModel
            {
                Tenchucnang = "DANH MỤC",
                Trang = typeof(HotExerciesPage),
                
            }); ;
            dscn.Add(new TabbedPageModel
            {
                Tenchucnang = "ĐỐI TƯỢNG",
                Trang = typeof(CategoryPage),

            }); ;
            dscn.Add(new TabbedPageModel
            {
                Tenchucnang = "KHÁM PHÁ",
                Trang = typeof(DiscoveryPage),

            }); ;
            for (int i = 0; i < dscn.Count; i++)
            {
                Page p = (Page)Activator.CreateInstance(dscn[i].Trang);
                p.Title = dscn[i].Tenchucnang;
                p.IconImageSource = dscn[i].Icon;
                Children.Add(p);
            }

        }

        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
                bool answer = await DisplayAlert("Question?", "Bạn muốn đăng xuất ?", "CÓ", "Ở LẠI");
                Debug.WriteLine("Answer: " + answer);
            if (answer)
            {
                 Navigation.PushAsync(new LoginPage());
            }
            
        }
    }
}