using HackatonProject.Models;
using HackatonProject.ViewModels;
using HackatonProject.Views;
using System;
using System.IO;
using Xamarin.Forms;

namespace HackatonProject
{
    public partial class App : Application
    {
        private static Database _database;
        public static User User { get; set; } = new();

        public static Database Database
        {
            get
            {
                if (_database == null)
                {
                    _database = CreateNewDataBase();
                }
                return _database;
            }
        }

        private static Database CreateNewDataBase()
        {
            string enviromentPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            const string databaseName = "users.db3";

            return new Database(Path.Combine(enviromentPath, databaseName));
        }

        public static NavigationCommandContainer<SignInView> SignInCommandContainer { get; set; }
        public static NavigationCommandContainer<LogInView> LogInCommandContainer { get; set; }
        public static NavigationCommandContainer<ProjectsView> HomeCommandContainer { get; set; }
        public static NavigationCommandContainer<AuthenticationView> AuthCommandContainer { get; set; }
        public static NavigationCommandContainer<SearchView> SearchViewContainer { get; set; }
        public static NavigationCommandContainer<PersonalProjectsView> PersonalProjectsViewContainer { get; set; }
        public static NavigationCommandContainer<ProfileView> ProfileViewContainer { get; set; }
        public static Action OnAction { get; internal set; }

        public App()
        {
            InitializeComponent();
            DependencyService.RegisterSingleton(this);

            MainPage = new NavigationPage(new WelcomeView());

            SerializeCommands();
        }

        public static void SerializeCommands()
        {
            SignInCommandContainer = new();
            LogInCommandContainer = new();
            SearchViewContainer = new();
            PersonalProjectsViewContainer = new();
            HomeCommandContainer = new();
            ProfileViewContainer = new();
            AuthCommandContainer = new();

            OnAction();
        }
    }
}