using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinTemplate.Views;

namespace XamarinTemplate.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        ContentView view = new HomeView();
        public ContentView View
        {
            get { return view; }
            set
            {
                SetProperty(ref view, value);
            }
        }
    }
}
