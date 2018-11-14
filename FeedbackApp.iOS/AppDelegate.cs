
using Foundation;
using UIKit;

[assembly: Xamarin.Forms.Dependency(typeof(FeedbackApp.iOS.AppDelegate))]
namespace FeedbackApp.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate, IDeviceInfo
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }


        #region Device Info Interface implementation
        /// <summary>
        /// Gets the device info.
        /// </summary>
        public DeviceInfo GetDeviceInfo()
        {
            return new DeviceInfo
            {
                DeviceName = UIDevice.CurrentDevice.Name,
                DeviceOS = UIDevice.CurrentDevice.SystemName,
                DeviceVersion = UIDevice.CurrentDevice.SystemVersion
            };
        }
        #endregion
    }
}
