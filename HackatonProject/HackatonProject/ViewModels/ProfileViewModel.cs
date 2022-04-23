using HackatonProject.Views;
using System.Windows.Input;

namespace HackatonProject.ViewModels
{
    public class ProfileViewModel
    {
        public ProfileViewModel()
        {
            SignInCommand = App.SearchViewContainer.Command;
            LogInCommand = App.PersonalProjectsViewContainer.Command;
            HomeInCommand = App.HomeCommandContainer.Command;
        }

        public ICommand SignInCommand { get; set; }
        public ICommand LogInCommand { get; set; }
        public ICommand HomeInCommand { get; set; }
    }
}