using System;
using System.Collections.Generic;
using EventsAndApis.ViewModels;
using Xamarin.Forms;

namespace EventsAndApis.Views
{
    public partial class MainPage : ContentPage
    {
        // added using EventsAndApis.ViewModels;
        MainVM viewModel;

        public MainPage()
        {
            InitializeComponent();

            viewModel = new MainVM();
            BindingContext = viewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            viewModel.GetLocationPermission();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            viewModel.StopListeningLocationUpdates();
        }
    }
}
