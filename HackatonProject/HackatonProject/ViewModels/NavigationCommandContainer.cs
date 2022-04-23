using System.Windows.Input;
using Xamarin.Forms;

namespace HackatonProject.ViewModels
{
    public class NavigationCommandContainer<View> where View : Page, new()
    {
        private readonly INavigation _navigation;
        private View _page = new();

        public ICommand Command { get; private set; }
        public View Page { get => _page; set => _page = value; }

        public NavigationCommandContainer()
        {
            Command = new Command(Navigate);

            _navigation = DependencyService.Get<INavigation>();
        }

        public async void Navigate()
        {
            await _navigation.PushAsync(Page);
        }
    }
}