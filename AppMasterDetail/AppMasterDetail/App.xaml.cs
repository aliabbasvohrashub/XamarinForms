using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppMasterDetail.Services;
using AppMasterDetail.Views;

namespace AppMasterDetail
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            DependencyService.Register<MockDataEmployee>();
            MainPage = new NavigationPage(new ListViewColors());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
