using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorkOutApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AllExercicesPage : ContentPage
    {
        public AllExercicesPage()
        {
            InitializeComponent();
            ListViewInit();
            
        }
         async void ListViewInit()
        {
            HttpClient httpClient = new HttpClient();

            var DsBaitap = await httpClient.GetStringAsync("http://192.168.1.10/webapiApp/api/ServiceController/GetAllBaiTap");

            var DsbaitapConverted = JsonConvert.DeserializeObject<List<Models.Baitap>>(DsBaitap);

            lst.ItemsSource = DsbaitapConverted;    
        }

        private void lst_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Models.Baitap baitap = (Models.Baitap)e.SelectedItem;
            Navigation.PushAsync(new ExerciceDetail(baitap));

        }

        private async void searchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            HttpClient httpClient = new HttpClient();

            var DsBaitap = await httpClient.GetStringAsync("http://192.168.1.10/webapiApp/api/ServiceController/GetAllBaiTap");

            var DsbaitapConverted = JsonConvert.DeserializeObject<List<Models.Baitap>>(DsBaitap);

            var keyword = searchBar.Text;
            lst.ItemsSource = DsbaitapConverted.Where(c => c.TENBAITAP.Contains(keyword.ToLower()));



        }

        private async void searchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            HttpClient httpClient = new HttpClient();

            var DsBaitap = await httpClient.GetStringAsync("http://192.168.1.10/webapiApp/api/ServiceController/GetAllBaiTap");


            var DsbaitapConverted = JsonConvert.DeserializeObject<List<Models.Baitap>>(DsBaitap);


            var keyword = searchBar.Text;
            lst.ItemsSource = DsbaitapConverted.Where(c => c.TENBAITAP.ToLower().Contains(keyword));

        }

        private void iconLike_Clicked(object sender, EventArgs e)
        {
           
        }
    }
}