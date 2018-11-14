using System;
using Xamarin.Forms;

namespace FeedbackApp.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        #region GLobal Fields
        public Command ProceedCommand { get; set; }
        DeviceInfo deviceInfo;
        #endregion

        #region Properties
        public DeviceInfo DeviceInfo
        {
            get
            {
                return deviceInfo;
            }
            set
            {
                deviceInfo = value;
                OnPropertyChanged();
            }
        }
        #endregion

        public MainViewModel()
        {
            deviceInfo = DependencyService.Get<IDeviceInfo>().GetDeviceInfo();
            ProceedCommand = new Command(ProceedClick);
        }

        #region Action Handlers
        /// <summary>
        /// Proceed click action.
        /// </summary>
        /// <param name="obj">Object.</param>
        void ProceedClick()
        {
            Application.Current.MainPage = new NavigationPage(new HomePage());
        }
        #endregion
    }
}
