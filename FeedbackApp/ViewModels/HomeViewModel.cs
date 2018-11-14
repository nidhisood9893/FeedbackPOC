using System;
using Xamarin.Forms;

namespace FeedbackApp
{
    public class HomeViewModel : ViewModelBase
    {
        #region GLobal Fields
        public Command AddCommand { get; set; }
        public Command ShowCommand { get; set; }
        HomePage homePage;
        #endregion

        public HomeViewModel(HomePage page)
        {
            homePage = page;
            AddCommand = new Command(AddClick);
            ShowCommand = new Command(ShowClick);
        }

        #region Action Handlers
        /// <summary>
        /// Add click action.
        /// </summary>
        void AddClick()
        {
            homePage.Navigation.PushAsync(new AddFeedbackPage());
        }

        /// <summary>
        /// Show click action.
        /// </summary>
        async void ShowClick()
        {
            // homePage.Navigation.PushAsync(new ShowFeedbacksPage());

            var list = await App.Database.GetFeedbacks();
        }

        #endregion
    }
}
