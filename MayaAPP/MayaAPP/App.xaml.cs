using MayaAPP.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;



namespace MayaAPP
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new RegisterPage();
            //MainPage = new NavigationPage(new Page(LoginPage));
            //MainPage = new SplashScreen.MainPage();
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
