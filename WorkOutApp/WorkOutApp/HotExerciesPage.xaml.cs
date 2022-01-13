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
    public partial class HotExerciesPage : ContentPage
    {
        public HotExerciesPage()
        {
            InitializeComponent();
        }

        private void cmdTapBung_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BTBungPage());
        }


        private void cmdtay_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BTTayPage());
        }

        private void cmdNguc_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BTNguc());

        }

        private void BTChan_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BTChan());
        }
    }
}