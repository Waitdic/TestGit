using I_am_a_programmer.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace I_am_a_programmer.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;
            // MenuPages.Add((int)MenuItemType.Browse, (NavigationPage)Detail);
        }

        private void ButtonAll_labsClick(object sender, EventArgs e)
        {
            
            Detail = new NavigationPage(new All_labs())
            {
                BarBackgroundColor = Color.FromHex("FF0000")
            };
            IsPresented = false;
        }

        private void ButtonMarksClick(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Marks())
            {
                BarBackgroundColor = Color.FromHex("FF0000")
            };
            IsPresented = false;
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