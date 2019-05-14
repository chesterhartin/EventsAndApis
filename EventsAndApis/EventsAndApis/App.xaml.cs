using System;
using EventsAndApis.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EventsAndApis
{
    public partial class App : Application
    {
        public static string DatabasePath;

        public App(string databasePath)
        {
            InitializeComponent();

            DatabasePath = databasePath;

            MainPage = new NavigationPage(new ExperiencesPage()); // added using EventsAndApis.Views;
        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ExperiencesPage());
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
