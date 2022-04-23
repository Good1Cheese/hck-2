using HackatonProject.Views;
using System.Windows.Input;

namespace HackatonProject.ViewModels
{
    public class ProjectsViewModel
    {
        private NavigationCommandContainer<SearchView> teest1;
        private NavigationCommandContainer<PersonalProjectsView> test2;
        public NavigationCommandContainer<ProfileView> test3 { get; set; }

        public ProjectsViewModel()
        {
            teest1 = App.SearchViewContainer;
            test2 = App.PersonalProjectsViewContainer;

            App.OnAction += NewMethod;
        }

        private void NewMethod()
        {
            test3 = App.ProfileViewContainer;
        }

        public NavigationCommandContainer<SearchView> SignInCommandContainer => teest1;
        public NavigationCommandContainer<PersonalProjectsView> LogInCommandContainer => test2;
    }
}