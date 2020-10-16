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
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage()
        {
            InitializeComponent();
        } 

        private void btnSignUp_Clicked(object sender, EventArgs e)
        {
            if(entPassword.Text != entConfPassword.Text)
            {
                DisplayAlert("Error", "passwords entered don't match", "Cancel");
            }
            else
            {
                Navigation.PushAsync(new MainPage());
            }


        }
    }
}