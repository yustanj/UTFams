using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinTemplate.Models;
using XamarinTemplate.Views;

namespace XamarinTemplate.ViewModels
{
    public class RegisterViewModel : BaseViewModel
    {
        public ICommand Register { get; set; }
        public ICommand Login { get; set; }
        public ICommand ForgotPassword { get; set; }

        public RegisterViewModel()
        {
            Register = new Command(register);
            Login = new Command(login);
            ForgotPassword = new Command(forgotpassword);
        }

        private void register()
        {
            GlobalVar.isLogin = true;
            currentpage = new HomePage();
        }
        private void login()
        {
            Navigation.PushAsync(new LoginPage()).GetAwaiter();
        }
        private void forgotpassword()
        {
            Navigation.PushAsync(new ForgotPasswordPage()).GetAwaiter();
        }
    }
}
