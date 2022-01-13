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
    public partial class NangCao_Page : ContentPage
    {
        public NangCao_Page()
        {
            InitializeComponent();
            ListViewInit();
        }
        async void ListViewInit()
        {
            HttpClient httpClient = new HttpClient();

            var DsBaitap = await httpClient.GetStringAsync("http://192.168.1.10/webapiApp/api/ServiceController/GetAllBaiTapNangCao");

            var DsbaitapConverted = JsonConvert.DeserializeObject<List<Models.Baitap>>(DsBaitap);

            lst_nangcao.ItemsSource = DsbaitapConverted;

        }

        private void lst_nangcao_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Models.Baitap baitap = (Models.Baitap)e.SelectedItem;
            Navigation.PushAsync(new ExerciceDetail(baitap));

        }
    }
}