﻿using System;
using System.Collections.Generic;
using IBook.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace IBook
{
    public partial class App : Application
    {
        public static IList<string> listChon = null ;
        public static User mainUser = null;
        public App()
        {
            InitializeComponent();
            mainUser = new User();
            listChon = new List<string>();
            MainPage = new NavigationPage(new View.PageLogin());
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
