using I_am_a_programmer.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using System.IO;

namespace I_am_a_programmer.Views
{
    public interface ISQLite
    {
        string GetDatabasePath(string filename);
    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();
            Detail = new NavigationPage(new Views.Buttons.PersonalArea())
            {
                BarBackgroundColor = Color.FromHex("FF0000")
            };
            MasterBehavior = MasterBehavior.Popover;
            
            // MenuPages.Add((int)MenuItemType.Browse, (NavigationPage)Detail);
        }

        //Никита
        private void Button_PersonalArea(object sender, EventArgs e)
        {
            
            Detail = new NavigationPage(new Views.Buttons.PersonalArea())
            {
                BarBackgroundColor = Color.FromHex("FF0000")
            };
            IsPresented = false;
        }

        //Степа
        private void Button_ServicePoints(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Views.Buttons.ServicePoints())
            {
                BarBackgroundColor = Color.FromHex("FF0000")
            };
            IsPresented = false;
        }

        //Витя
        private void Button_Map(object sender, EventArgs e)
        {

            Detail = new NavigationPage(new Views.Buttons.Map())
            {
                BarBackgroundColor = Color.FromHex("FF0000")
            };
            IsPresented = false;
        }

       // Паша
        private void Button_Products(object sender, EventArgs e)
        {

            Detail = new NavigationPage(new Views.Buttons.Products())
            {
                BarBackgroundColor = Color.FromHex("FF0000")
            };
            IsPresented = false;
        }

        //Миша
        private void Button_Personnel(object sender, EventArgs e)
        {

            Detail = new NavigationPage(new Views.Buttons.Personnel())
            {
                BarBackgroundColor = Color.FromHex("FF0000")
            };
            IsPresented = false;
        }

        private void Button_AboutApp(object sender, EventArgs e)
        {

            Detail = new NavigationPage(new Views.Buttons.AboutApp())
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