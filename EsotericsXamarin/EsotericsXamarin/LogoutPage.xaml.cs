﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EsotericsXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LogoutPage : ContentPage
    {
        public LogoutPage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {

            bool result = await DisplayAlert(null, "Are you sure on to Logout", "Yes", "No");

            if (result)
            {

            }

            else
                await Shell.Current.GoToAsync("//Name");

            base.OnAppearing();
        }
    }
}