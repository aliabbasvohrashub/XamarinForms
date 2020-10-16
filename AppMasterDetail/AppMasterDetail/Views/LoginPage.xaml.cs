using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppMasterDetail.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Hi", "Your are about to enter the application", "ya", "nai");
            Application.Current.MainPage = new MainPage();
        }

        private void SignUpTapper(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SignUpPage());
        }
    }
}