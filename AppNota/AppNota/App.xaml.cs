﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppNota.Views;

namespace AppNota
{
    public partial class App : Application
    {
        public static String DbName;
        public static String DbPath;
        public App()
        {
            InitializeComponent();

            MainPage = new PagePrincipal();
        }

        public App(string dbPath, string dbName)
        {
            InitializeComponent();
            App.DbName = dbName;
            App.DbPath = dbPath;
            MainPage = new PagePrincipal();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
