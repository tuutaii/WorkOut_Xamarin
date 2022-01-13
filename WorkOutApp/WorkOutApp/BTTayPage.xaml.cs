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
    public partial class BTTayPage : ContentPage
    {
        public BTTayPage()
        {
            InitializeComponent();
            ListViewInit();
        }

        async void ListViewInit()
        {
            HttpClient httpClient = new HttpClient();

            var DsBaitap = await httpClient.GetStringAsync("http://192.168.1.10/webapiApp/api/ServiceController/GetBTTay");

            var DsbaitapConverted = JsonConvert.DeserializeObject<List<Models.Baitap>>(DsBaitap);

            lst_BTTay.ItemsSource = DsbaitapConverted;
        }
        private void lst_BTTay_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            
            Models.Baitap baitap = (Models.Baitap)e.SelectedItem;
            Navigation.PushAsync(new ExerciceDetail(baitap));

        }
    }
}