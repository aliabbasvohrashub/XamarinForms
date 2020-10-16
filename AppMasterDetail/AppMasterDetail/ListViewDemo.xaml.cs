using AppMasterDetail.Models;
using AppMasterDetail.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppMasterDetail
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewDemo : ContentPage
    {
        private ListViewDemoViewModel GetViewDemoViewModel = new ListViewDemoViewModel();
        public ListViewDemo()
        {
            BindingContext = GetViewDemoViewModel;
        }
    }
}