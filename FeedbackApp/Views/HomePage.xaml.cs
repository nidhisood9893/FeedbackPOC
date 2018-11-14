using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FeedbackApp
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            BindingContext = new HomeViewModel(this);
        }
    }
}
