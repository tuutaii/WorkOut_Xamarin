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
    public partial class HotExercicesPageDetail : ContentPage
    {
        public HotExercicesPageDetail()
        {
            InitializeComponent();
        }
        public HotExercicesPageDetail(Models.Baitap baitap)
        {
            InitializeComponent();
            GetBaiTapBung(baitap.ID_BAITAP);
            Title = baitap.TENBAITAP;

        }
        async void GetBaiTapBung(int baitapID)
        {
            HttpClient httpClient = new HttpClient();

            var lstBaitap = await httpClient.GetStringAsync("http://192.168.1.10/webapiApp/api/ServiceController/GetBTBung");

            var lstBaitapConverted = JsonConvert.DeserializeObject<List<Models.Baitap>>(lstBaitap);

            lstHotDetail.ItemsSource = lstBaitapConverted;
        }

    }
}