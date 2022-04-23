using HackatonProject.Models;
using HackatonProject.Views;
using System.Windows.Input;
using Xamarin.Forms;

namespace HackatonProject.ViewModels
{
    public class LogInViewModel
    {
        private ContentPage _page;

        public LogInViewModel(LogInView logInView)
        {
            _page = logInView;

            LogInCommand = new Command(LogIn);
        }

        public User UserToLogIn { get; set; } = new();
        public ICommand LogInCommand { get; private set; }

        private void LogIn()
        {
            if (UserToLogIn.Email == default || UserToLogIn.Password == default)
            {
                _page.DisplayAlert("Error", "One of fields is empty", "Ok");
                return;
            }

            var user = App.Database.FindUser(UserToLogIn).FirstOrDefaultAsync().Result;

            if (user == null)
            {
                _page.DisplayAlert("Error", "This user doesnt exists", "Ok");
            }

            _page.DisplayAlert("Succses", "Logged In", "Ok");
            App.User = user;
        }
    }
}