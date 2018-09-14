using RestSharp;
using System;
using XamarinTemplate.ViewModels;
using XamarinTemplate.Views;

namespace XamarinTemplate.Models
{
    public static class GlobalVar
    {
        //init template
        public static string BaseUrl = "https://api.loyalto.id/api/v1/";
        public static RestClient Domain => new RestClient(BaseUrl);
        public static string DataFolderName => "Xamarin";
        public static string DataFileName => "Xamarin";

        public static string SavedData { get; set; }

        public static dynamic[] DataToSave
        {
            get { return new dynamic[] { SavedData, isLogin }; }
            set
            {
                SavedData = value[0];
                isLogin = Boolean.Parse(value[1]);
            }
        }

        public static bool NotifShown { get; set; }

        static bool islogin = false;
        public static bool isLogin
        {
            get { return islogin; }
            set
            {
                BaseViewModel Base = new BaseViewModel();
                islogin = value;
                TextData.SaveData(DataToSave);

                if (value == true)
                {

                    Base.currentpage = new MainPage();
                }
                else
                {
                    Base.currentpage = new MainPage();
                }
            }
        }
    }
}