using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorkOutApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [DesignTimeVisible(false)]
    public partial class ExerciceDetail : ContentPage
    {
        private double _ProgressValue;
        public double ProgressValue
        {
            get
            {
                return _ProgressValue;
            }
            set
            {
                _ProgressValue = value;
                OnPropertyChanged();
            }
        }
        private double _Minimum;
        public double Minimum
        {
            get
            {
                return _Minimum;
            }
            set
            {
                _Minimum = value;
                OnPropertyChanged();
            }
        }
        private double _Maximum;
        public double Maximum
        {
            get
            {
                return _ProgressValue;
            }
            set
            {
                _ProgressValue = value;
                OnPropertyChanged();
            }
        }
        private Timer time = new Timer();
        private bool timerRunning;

        public ExerciceDetail()
        {
            InitializeComponent();
     
        }

        public  ExerciceDetail(Models.Baitap baitap)
        {
            InitializeComponent();
            GetBaiTapTheoID(baitap.ID_BAITAP);
            Title = baitap.TENBAITAP;
            //Lable1.Text = baitap.THOILUONG.ToString();
            BindingContext = this;
            Minimum = 0;
            Maximum = baitap.THOILUONG;
            ProgressValue = baitap.THOILUONG;
            timerRunning = true;
           
        }

        async void GetBaiTapTheoID(int baitapID )
        {
            HttpClient httpClient = new HttpClient();

            var lstBaitap = await httpClient.GetStringAsync("http://192.168.1.10/webapiApp/api/ServiceController/GetAllBaiTapbyID?ID_baitap="
            + baitapID.ToString());

            var lstBaitapConverted = JsonConvert.DeserializeObject<List<Models.Baitap>>(lstBaitap);

            lstDetail.ItemsSource = lstBaitapConverted;

        }

        private async void cmdStart_Clicked(object sender, EventArgs e)
        {
            cmdStart.Text = "TẠM DỪNG";
            time.Start();
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                if (ProgressValue > Minimum)
                {
                    ProgressValue--;
                    return true;
                }
                else if (ProgressValue == Minimum)
                {
                    time.Stop();
                    timerRunning = false;
                    DisplayAlert("Notification", "Bạn đã hoàn thành bài tập rồi !!", "Ok");
                    return false;
                }
                else
                {
                    return true;
                }
            });
        }
    }
}