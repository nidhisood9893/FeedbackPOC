using Xamarin.Forms;

namespace FeedbackApp
{
    public class AddViewModel : ViewModelBase
    {
        #region GLobal Fields
        AddFeedbackPage addFeedbackPage;
        public Command AddCommand { get; set; }
        Feedback feedback;
        #endregion

        #region Properties
        public Feedback Feedback
        {
            get
            {
                return feedback;
            }
            set
            {
                feedback = value;
                OnPropertyChanged();
            }
        }
        #endregion

        public AddViewModel(AddFeedbackPage addFeedbackPage)
        {
            this.addFeedbackPage = addFeedbackPage;
            AddCommand = new Command(AddClick);
            Feedback = new Feedback();
        }

        #region Action Handlers
        /// <summary>
        /// Add click action.
        /// </summary>
        async void AddClick()
        {
            if (string.IsNullOrEmpty(Feedback.Name))
                ShowAlert.ShowAlertOnPage(addFeedbackPage, (string)Application.Current.Resources["nameAlert"]);
            else if (string.IsNullOrEmpty(Feedback.ContactNumber))
                ShowAlert.ShowAlertOnPage(addFeedbackPage, (string)Application.Current.Resources["numberAlert"]);
            else if (string.IsNullOrEmpty(Feedback.Description))
                ShowAlert.ShowAlertOnPage(addFeedbackPage, (string)Application.Current.Resources["descriptionAlert"]);
            else if (Feedback.Rating.ToString().Equals("0"))
                ShowAlert.ShowAlertOnPage(addFeedbackPage, (string)Application.Current.Resources["rateAlert"]);
            else
            {
                await App.Database.AddFeedback(Feedback);
                await addFeedbackPage.Navigation.PopAsync();
            }
        }
        #endregion
    }
}