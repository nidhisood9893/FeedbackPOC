using System;
using System.ComponentModel;
namespace FeedbackApp
{
    public class DeviceInfo : INotifyPropertyChanged
    {
        public string DeviceName { get; set; }
        public string DeviceOS { get; set; }
        public string DeviceVersion { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
