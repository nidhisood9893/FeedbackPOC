using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FeedbackApp
{
    public partial class AddFeedbackPage : ContentPage
    {
        public AddFeedbackPage()
        {
            InitializeComponent();
            BindingContext = new AddViewModel(this);
        }
    }
}
