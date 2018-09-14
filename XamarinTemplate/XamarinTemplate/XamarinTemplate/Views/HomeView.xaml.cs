using Microcharts;
using Microcharts.Forms;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Entry = Microcharts.Entry;

namespace XamarinTemplate.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeView : ContentView
    {
        static int slideposition = 0;
        List<Entry> EnergyData = new List<Entry>
        {
            new Entry(250)
            {
                Color=SKColor.Parse("#FF1943"),
                Label ="Solar",
                ValueLabel = "25%"
            },
            new Entry(110)
            {
                Color = SKColor.Parse("00BFFF"),
                Label = "Fuel",
                ValueLabel = "11%"
            },
            new Entry(640)
            {
                Color =  SKColor.Parse("#00CED1"),
                Label = "PLN",
                ValueLabel = "64%"
            }
        };

        List<Entry> WaterData = new List<Entry>
        {
            new Entry(250)
            {
                Color=SKColor.Parse("#FF1943"),
                Label ="Sungai",
                ValueLabel = "25%"
            },
            new Entry(110)
            {
                Color = SKColor.Parse("00BFFF"),
                Label = "Sumur",
                ValueLabel = "11%"
            },
            new Entry(640)
            {
                Color =  SKColor.Parse("#00CED1"),
                Label = "PDAM",
                ValueLabel = "64%"
            }
        };


        List<string> slide = new List<string>() {
                "slider.png",
                "slider1.png",
                "slider2.png",
                "slider3.png"
            };

        public HomeView()
        {
            InitializeComponent();

            EnergyConsumptions.Chart = new DonutChart() { Entries = EnergyData, HoleRadius = 0.7f };
            WaterConsumptions.Chart = new DonutChart() { Entries = WaterData, HoleRadius = 0.7f };
            EnergyUsage.Children.Add(new BarchartMeter(63) { VerticalOptions = LayoutOptions.FillAndExpand, WidthRequest = 30 });

            SlideShowImages.ItemsSource = slide;
        }
    }
}