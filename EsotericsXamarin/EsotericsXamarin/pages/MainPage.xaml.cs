﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EsotericsXamarin
{
    public partial class MainPage : Shell
    {
        public MainPage()
        {
            InitializeComponent();

            screenFloyuot.Title = AppResources.ScreenText;
            //logoutFloyout.Title = AppResources.LogoutText;
            historyFloyout.Title = AppResources.HistoryText;
        }
    }
}
