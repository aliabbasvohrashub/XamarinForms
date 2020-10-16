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
    public partial class ListViewColors : ContentPage
    {
        public List<ColorClass> Items { get; set; }
        public ListViewColors()
        {
            InitializeComponent();
            Items = new List<ColorClass>();
            Items.Add(new ColorClass { Color = "Accent", FriendlyName = "test", RgbDisplay = "12-32-43" });
            Items.Add(new ColorClass { Color = "Yellow", FriendlyName = "test", RgbDisplay = "12-32-43" });
            Items.Add(new ColorClass { Color = "AliceBlue", FriendlyName = "test", RgbDisplay = "12-32-43" });
            Items.Add(new ColorClass { Color = "Bisque", FriendlyName = "test", RgbDisplay = "12-32-43" });
            Items.Add(new ColorClass { Color = "Cyan", FriendlyName = "test", RgbDisplay = "12-32-43" });
            Items.Add(new ColorClass { Color = "DarkGreen", FriendlyName = "test", RgbDisplay = "12-32-43" });

            BindingContext = Items;

        }

         
    }

    public class ColorClass
    {
        public string Color { get; set; }
        public string FriendlyName { get; set; }
        public string RgbDisplay { get; set; }
    }
}