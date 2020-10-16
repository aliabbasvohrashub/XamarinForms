using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppMasterDetail.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BasicList : ContentPage
    {
        private MyClass myClass;
        public BasicList()
        {
            InitializeComponent();
            myClass = new MyClass
            {
                Title = "this is the title",
                Name = "this is the name",
                strList = new[] { "a", "b", "c" }
            };
            BindingContext = myClass;
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e == null)
            {
                return;
            }

            Debug.WriteLine($"item tapped :  {e.Item}");
            ((ListView)sender).SelectedItem = null;
        }


        public class MyClass
        {
            public string Title { get; set; }
            public string Name { get; set; }
            public string[] strList { get; set; }
        }

    }
}