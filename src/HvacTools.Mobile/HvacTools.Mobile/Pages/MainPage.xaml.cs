﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HvacTools.Mobile.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
        }

        async void OnStartClick(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainMenuPage());
        }
    }
}
