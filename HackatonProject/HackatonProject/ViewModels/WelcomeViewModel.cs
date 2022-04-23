using System.Windows.Input;
using Xamarin.Forms;

namespace HackatonProject.ViewModels
{
    public class WelcomeViewModel
    {
        public WelcomeViewModel()
        {
            AuthCommand = App.AuthCommandContainer.Command;
        }

        public ICommand AuthCommand { get; set; }
        public string[] Test { get; set; } = new string[] { "", "", "" };
    }
}