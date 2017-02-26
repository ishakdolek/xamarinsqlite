﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AppSqlLite.View;
using Xamarin.Forms;

namespace AppSqlLite
{
    public class App : Application
    {
        public static string DbName { get; set; } = "appSample.db3";
        public App()
        {

            MainPage= new NavigationPage(new ListPage());

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
}
