using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace FeedbackApp
{
    public partial class App : Application
    {
        static FeedbackDatabase database;
        static bool showHome { get; set; }

        public App()
        {
            InitializeComponent();
            if (showHome)
                MainPage = new NavigationPage(new MainPage());
            else
            {
                MainPage = new MainPage();
                showHome = true;
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        #region Database
        public static FeedbackDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new FeedbackDatabase(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "feedback.db3"));
                }
                return database;
            }
        }
        #endregion

    }
}
