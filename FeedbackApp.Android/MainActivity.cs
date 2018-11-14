
using Android.App;
using Android.Content.PM;
using Android.OS;

[assembly: Xamarin.Forms.Dependency(typeof(FeedbackApp.Droid.MainActivity))]
namespace FeedbackApp.Droid
{
    [Activity(Label = "FeedbackApp", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity, IDeviceInfo
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }

        #region Device Info Interface implementation
        /// <summary>
        /// Gets the device info.
        /// </summary>
        public DeviceInfo GetDeviceInfo()
        {
            string manufacturer = Build.VERSION.Codename;
            string model = Build.Model;
            string device = Build.Device;

            return new DeviceInfo
            {
                DeviceName = device,
                DeviceVersion = Build.VERSION.Release,
                DeviceOS = "Android"
            };
        }
        #endregion
    }
}

