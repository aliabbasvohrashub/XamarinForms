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
    public partial class ContextListView : ContentPage
    {
        ObservableCollection<string> items;
        public ContextListView()
        {
            InitializeComponent();

            items = new ObservableCollection<string> { "alpha", "beta", "theta", "gamma", "eeta" };
            listView.SetBinding(ListView.ItemsSourceProperty, new Binding("."));
            listView.ItemsSource = items;
        }

        private void onMore(object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);
            DisplayAlert("More Context Action", mi.CommandParameter + " more context action", "OK");
        }

        private void onDelete(object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);
            DisplayAlert("More Context Action", mi.CommandParameter + " more context action", "OK");
        }

        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null) return; // has been set to null, do not 'process' tapped event
            DisplayAlert("Tapped", e.SelectedItem + " row was tapped", "OK");
            ((ListView)sender).SelectedItem = null; // de-select the row
        }
    }
}