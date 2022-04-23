using HackatonProject.Models;
using HackatonProject.Views;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace HackatonProject.ViewModels
{
    public class SignInViewModel
    {
        private ContentPage _page;

        public SignInViewModel(SignInView signInView)
        {
            _page = signInView;

            SignInCommand = new Command(SignIn);
        }


        public User SignInUser { get; set; } = new();
        public ICommand SignInCommand { get; private set; }
        public ICommand TestCommand { get; private set; }


        private void SignIn()
        {
            if (SignInUser.Name == default || SignInUser.Telephone == default || SignInUser.Email == default || SignInUser.Password == default)
            {
                _page.DisplayAlert("Error", "One of fields is empty", "Ok");
                return;
            }

            _page.DisplayAlert("Succses", "User added", "Ok");
            App.Database.SaveUserAsync(SignInUser).Wait();
        }
    }
}