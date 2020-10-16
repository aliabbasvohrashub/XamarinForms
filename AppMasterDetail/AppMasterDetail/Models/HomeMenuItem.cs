using System;
using System.Collections.Generic;
using System.Text;

namespace AppMasterDetail.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        OneMorePage,
        Contacts,
        BasicListView,
        ContextListView,
        HeaderFooter
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
