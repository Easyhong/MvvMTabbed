using System;
using MvvMTabbed.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MvvMTabbed
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TabBarPage();
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
