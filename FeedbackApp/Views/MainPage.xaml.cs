using Xamarin.Forms;
using FeedbackApp.ViewModels;

namespace FeedbackApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BindingContext = new MainViewModel();
        }
    }
}
