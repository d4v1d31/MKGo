﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MKGo
{
    public partial class App : Application
    {

        static Items items;

        public App()
        {
            InitializeComponent();

            MainPage = new MKGo.MainPage();
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

        public static Items Items
        {
            get
            {
                if (items == null)
                {
                    items = new Items();
                }
                return items;
            }
        }

    }
}
