using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinTemplate.Models;

namespace XamarinTemplate.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProfilView : ContentView
	{
		public ProfilView ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            GlobalVar.isLogin = false;
            App.Current.MainPage = new NavigationPage(new LoginPage());
        }
    }
}