﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace I_am_a_programmer.Views.Buttons
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PersonalArea : ContentPage
	{
		public PersonalArea ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (Login.Text != null & Password.Text != null)
            {
            }
            else
                DisplayAlert("Alert!", "Enter login and password!", "OK");
        }
    }
}