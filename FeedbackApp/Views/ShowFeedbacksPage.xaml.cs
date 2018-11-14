using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FeedbackApp
{
    public partial class ShowFeedbacksPage : ContentPage
    {
        public ShowFeedbacksPage()
        {
            InitializeComponent();
            BindingContext = new FeedbacksViewModel(this);
        }
    }
}
