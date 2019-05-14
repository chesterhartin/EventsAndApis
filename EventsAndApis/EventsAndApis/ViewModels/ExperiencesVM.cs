using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using EventsAndApis.Model;
using EventsAndApis.ViewModels.Commands;
using EventsAndApis.Views;

namespace EventsAndApis.ViewModels
{
    public class ExperiencesVM : INotifyPropertyChanged
    {
        // added using EventsAndApis.ViewModels.Commands;
        public NewExperienceCommand NewExperienceCommand { get; set; }

        public ObservableCollection<Experience> Experiences { get; set; }

        public ExperiencesVM()
        {
            NewExperienceCommand = new NewExperienceCommand(this);
            Experiences = new ObservableCollection<Experience>();
            ReadExperiences();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NewExperience()
        {
            App.Current.MainPage.Navigation.PushAsync(new MainPage());
        }

        public void ReadExperiences()
        {
            // added using EventsAndApis.Model;
            var experiences = Experience.GetExperiences();

            Experiences.Clear();
            foreach (var experience in experiences)
            {
                Experiences.Add(experience);
            }
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
