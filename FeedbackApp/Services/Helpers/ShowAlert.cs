using System;
using Xamarin.Forms;

namespace FeedbackApp
{
    public static class ShowAlert
    {
        public static string AppName = (string)Application.Current.Resources["appName"];

        public static void ShowAlertOnPage(Page page, string message)
        {
            if (page != null)
            {
                page.DisplayAlert(AppName, message, "OK");
            }
        }

        /// <summary>
        /// Shows Alerts the with two values async.
        /// </summary>
        /// <returns>The with twovalues asyn.</returns>
        /// <param name="pageContext">Page context.</param>
        /// <param name="message">Message.</param>
        /// <param name="option1">Option1.</param>
        /// <param name="option2">Option2.</param>
        public static async System.Threading.Tasks.Task<bool> AlertWithTwovaluesAsync(Page pageContext, string message, string option1, string option2)
        {
            var success = await pageContext.DisplayAlert(AppName, message, option1, option2);
            return success;
        }

        /// <summary>
        /// Prints the custom log.
        /// </summary>
        /// <param name="title">Title.</param>
        /// <param name="message">Message.</param>
        public static void PrintLog(string title, string message)
        {
            Console.WriteLine(title + ": " + message);
        }
    }
}
