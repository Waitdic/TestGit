using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using I_am_a_programmer.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace I_am_a_programmer
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();


            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
} //fsfasf
