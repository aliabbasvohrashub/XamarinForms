﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using AppMasterDetail.Models;

namespace AppMasterDetail.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        //public event EventHandler IsPresentedChanged;

        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.Browse, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Browse:
                        MenuPages.Add(id, new NavigationPage(new ItemsPage()));
                        break;
                    case (int)MenuItemType.About:
                        MenuPages.Add(id, new NavigationPage(new AboutPage()));
                        break;
                    case (int)MenuItemType.OneMorePage:
                        MenuPages.Add(id, new NavigationPage(new NextPage()));
                        break;
                    case (int)MenuItemType.Contacts:
                        MenuPages.Add(id, new NavigationPage(new ContactsPage()));
                        break;
                    case (int)MenuItemType.BasicListView:
                        MenuPages.Add(id, new NavigationPage(new BasicList()));
                        break;
                    case (int)MenuItemType.ContextListView:
                        MenuPages.Add(id, new NavigationPage(new ContextListView()));
                        break;
                    case (int)MenuItemType.HeaderFooter:
                        MenuPages.Add(id, new NavigationPage(new HeaderFooter()));
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}