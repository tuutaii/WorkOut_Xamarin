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
    public partial class CategoryPage : ContentPage
    {
        public CategoryPage()
        {
            InitializeComponent();
        }

        private void cmdForNew_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ChoNguoiMoi_Page());
        }

        private void cmdForMedium_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TrungBinh_Page());

        }

        private void cmdForAdv_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NangCao_Page());


        }

        private void cmdForHome_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TaiNha_Page());

        }
    }
}