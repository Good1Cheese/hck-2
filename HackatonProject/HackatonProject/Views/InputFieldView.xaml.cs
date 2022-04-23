using Xamarin.Forms;

namespace HackatonProject.Views
{
    public partial class InputFieldView : ContentView
    {
        public string Text { get; set; }
        public string PlaceHolder { get; set; }

        public InputFieldView()
        {
            InitializeComponent();

            PreviewField.Text = Text;
            PlaceHolderField.Text = PlaceHolder;
        }
    }
}