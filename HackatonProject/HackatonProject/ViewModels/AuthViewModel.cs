using HackatonProject.Views;
using System.Windows.Input;

namespace HackatonProject.ViewModels
{
    public class AuthViewModel
    {
        public AuthViewModel()
        {
            SignInCommand = App.SignInCommandContainer.Command;
            LogInCommand = App.LogInCommandContainer.Command;
            HomeInCommand = App.HomeCommandContainer.Command;
        }

        public ICommand SignInCommand { get; set; }
        public ICommand LogInCommand { get; set; }
        public ICommand HomeInCommand { get; set; }

        public string[] Test { get; set; } = new string[] { "", "", "", "" };
    }
}