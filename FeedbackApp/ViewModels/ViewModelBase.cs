using System;
using System.ComponentModel;

namespace FeedbackApp
{
    /// <summary>
    /// This class acts as a base class for all ViewModel classes to implement INotifyPropertyChanged
    /// </summary>
    public class ViewModelBase : INotifyPropertyChanged
    {
        public ViewModelBase()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
