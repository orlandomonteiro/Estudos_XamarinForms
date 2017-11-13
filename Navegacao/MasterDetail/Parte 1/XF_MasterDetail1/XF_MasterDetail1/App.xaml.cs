﻿using Xamarin.Forms;
using XF_MasterDetail1.Views;

namespace XF_MasterDetail1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new MasterDetail();
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