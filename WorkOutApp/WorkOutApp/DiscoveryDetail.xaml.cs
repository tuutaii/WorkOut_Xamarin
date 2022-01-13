using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkOutApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorkOutApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DiscoveryDetail : ContentPage
    {
        public DiscoveryDetail()
        {
            InitializeComponent();

            List<ImageDiscoveryPage> images = new List<ImageDiscoveryPage>()
            {
                new ImageDiscoveryPage(){Title="Image 1",Url="news1.jfif"},
                new ImageDiscoveryPage(){Title="Image 2",Url="news2.jfif"},
                new ImageDiscoveryPage(){Title="Image 3",Url="news3.jfif"}
            };

            carouselView.ItemsSource = images;

            Device.StartTimer(TimeSpan.FromSeconds(3), (Func<bool>)(() =>
            {
                carouselView.Position = (carouselView.Position + 1) % images.Count;
                return true;
            }));

        }
    }
}