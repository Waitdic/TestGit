using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Математишка", "а ты сдал все лабы? да? ну ладно 3." , "OK:(");
            var image = new Image { Source = "Matematishka" };
        }
    }

   
}

