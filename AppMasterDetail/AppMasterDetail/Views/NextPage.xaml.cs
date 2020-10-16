using AppMasterDetail.Helper;
using AppMasterDetail.Models;
using AppMasterDetail.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppMasterDetail.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NextPage : ContentPage
    {
        NextPageViewModel viewModel;
        public NextPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new NextPageViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.employees.Count == 0)
            {
                //viewModel.employeeCommand.Execute(null);
            }
        }
    }
}