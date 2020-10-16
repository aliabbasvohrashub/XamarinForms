using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppMasterDetail.Views
{
    public class Monkey
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class MonkeyVM
    {
        public List<Monkey> Monkeys { get; set; }
        public string Intro { get { return "Monkey Header"; } }
        public string Summary { get { return " There were " + Monkeys.Count + " monkeys"; } }
        public MonkeyVM()
        {
            var monkeys = new List<Monkey> {
                new Monkey {Name="Xander", Description="Writer"},
                new Monkey {Name="Rupert", Description="Engineer"},
                new Monkey {Name="Tammy", Description="Designer"},
                new Monkey {Name="Blue", Description="Speaker"},
				// new Monkey {Name="e", Description="eee"},
				// new Monkey {Name="f", Description="fff"},
				// new Monkey {Name="g", Description="ggg"},
				// new Monkey {Name="i", Description="iii"},
				// new Monkey {Name="j", Description="jjj"},
				// new Monkey {Name="k", Description="kkk"},
				// new Monkey {Name="l", Description="lll"},
				// new Monkey {Name="m", Description="mmm"},
				// new Monkey {Name="n", Description="nnn"},
				// new Monkey {Name="o", Description="ooo"},
			};
            Monkeys = monkeys;
        }
    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HeaderFooter : ContentPage
    {
        public HeaderFooter()
        {
            InitializeComponent();
            BindingContext = new MonkeyVM();
        }
    }
}