using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinTemplate.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BarchartMeter : ContentView
    {
        List<string> ColorGradient = new List<string>() {
            "31E602",
            "61E804",
            "92EA06",
            "C2EC09",
            "EEE90B",
            "EFBD0D",
            "F19210",
            "F36612",
            "F53B15",
            "F7181E"
        };
        public BarchartMeter(int value)
        {
            InitializeComponent();


            Grid chart = new Grid { RowSpacing = 0, VerticalOptions = LayoutOptions.FillAndExpand};


            RowDefinitionCollection row = new RowDefinitionCollection();
            for (int i = 0; i < 100; i++)
            {
                row.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            }

            int count = 0;
            while (count < value)
            {

                string color;
                if (count > 10)
                {
                    color = count.ToString().Substring(0, 1);
                }
                else
                {
                    color = "0";
                }

                chart.Children.Add(new Grid { BackgroundColor = Color.FromHex(ColorGradient[int.Parse(color)]), RowSpacing = 0 }, 0, 99 - count);

                count++;
            }

            Content = chart;
        }
    }
}