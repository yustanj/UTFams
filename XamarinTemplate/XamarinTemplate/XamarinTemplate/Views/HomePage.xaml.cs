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
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();

            MainContent.Children.Add(new HomeView());
        }
        private void Home_Tapped(object sender, EventArgs e)
        {
            MainContent.Children.Clear();
            MainContent.Children.Add(new HomeView());

            Home.BackgroundColor = (Color)Application.Current.Resources["DefaultColor"];
            Ticket.BackgroundColor = Color.Transparent;
            RegularMT.BackgroundColor = Color.Transparent;
            Inbox.BackgroundColor = Color.Transparent;
            Profil.BackgroundColor = Color.Transparent;
        }

        private void Ticket_Tapped(object sender, EventArgs e)
        {
            MainContent.Children.Clear();
            MainContent.Children.Add(new TicketView());

            Ticket.BackgroundColor = (Color)Application.Current.Resources["DefaultColor"];
            Home.BackgroundColor = Color.Transparent;
            RegularMT.BackgroundColor = Color.Transparent;
            Inbox.BackgroundColor = Color.Transparent;
            Profil.BackgroundColor = Color.Transparent;
        }

        private void RegularMT_Tapped(object sender, EventArgs e)
        {
            MainContent.Children.Clear();
            MainContent.Children.Add(new RegularMTView());

            RegularMT.BackgroundColor = (Color)Application.Current.Resources["DefaultColor"];
            Home.BackgroundColor = Color.Transparent;
            Ticket.BackgroundColor = Color.Transparent;
            Inbox.BackgroundColor = Color.Transparent;
            Profil.BackgroundColor = Color.Transparent;
        }

        private void Inbox_Tapped(object sender, EventArgs e)
        {
            MainContent.Children.Clear();
            MainContent.Children.Add(new InboxView());

            Inbox.BackgroundColor = (Color)Application.Current.Resources["DefaultColor"];
            Home.BackgroundColor = Color.Transparent;
            Ticket.BackgroundColor = Color.Transparent;
            RegularMT.BackgroundColor = Color.Transparent;
            Profil.BackgroundColor = Color.Transparent;
        }

        private void Profil_Tapped(object sender, EventArgs e)
        {
            MainContent.Children.Clear();
            MainContent.Children.Add(new ProfilView());

            Profil.BackgroundColor = (Color)Application.Current.Resources["DefaultColor"];
            Home.BackgroundColor = Color.Transparent;
            Ticket.BackgroundColor = Color.Transparent;
            RegularMT.BackgroundColor = Color.Transparent;
            Inbox.BackgroundColor = Color.Transparent;
        }
    }
}