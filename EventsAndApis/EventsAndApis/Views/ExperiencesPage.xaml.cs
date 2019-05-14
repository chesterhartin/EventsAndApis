using System;
using System.Collections.Generic;
using EventsAndApis.ViewModels;
using Xamarin.Forms;

namespace EventsAndApis.Views
{
    public partial class ExperiencesPage : ContentPage
    {
        ExperiencesVM viewModel;
        public ExperiencesPage()
        {
            InitializeComponent();

            viewModel = Resources["vm"] as ExperiencesVM;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            viewModel.ReadExperiences();
        }
    }
}
