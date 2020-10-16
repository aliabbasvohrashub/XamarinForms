using AppMasterDetail.Models;
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
    public partial class ContactsPage : ContentPage
    {
        public ObservableCollection<Contacts> ContactsList;
        public ContactsPage()
        {
            InitializeComponent();
            BindingContext = this;
            ContactsList = new ObservableCollection<Contacts>();

            for (int i = 1; i < 21; i++)
            {
                ContactsList.Add(new Contacts() { Id = i, Name = $"student{i}", Address = $"address {i}" });
            }

            ContactsListView.ItemsSource = ContactsList;
        }

        private void MenuItem_Clicked(object sender, EventArgs e)
        {

        }
    }
}