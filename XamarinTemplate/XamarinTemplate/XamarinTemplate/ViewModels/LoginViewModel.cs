using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinTemplate.Models;
using XamarinTemplate.Views;

namespace XamarinTemplate.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public ICommand Login { get; set; }
        public ICommand Register { get; set; }
        public ICommand ForgotPassword { get; set; }

        public LoginViewModel()
        {
            Login = new Command(login);
            Register = new Command(register);
            ForgotPassword = new Command(forgotpassword);
        }

        private void login()
        {
            GlobalVar.isLogin = true;
            currentpage = new HomePage();
        }
        private void register()
        {
            Navigation.PushAsync(new RegisterPage()).GetAwaiter();
        }
        private void forgotpassword()
        {
            Navigation.PushAsync(new ForgotPasswordPage()).GetAwaiter();
        }
    }
}
