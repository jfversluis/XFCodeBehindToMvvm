using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace XFCodeBehindToMvvm
{
    public class MainPageModel : INotifyPropertyChanged
    {
        public string EntryValue { get; set; }
        public string TitleValue { get; set; }

        public Command ChangeTitleCommand { get; set; }

        public MainPageModel()
        {
            ChangeTitleCommand = new Command(() =>
            {
                TitleValue = EntryValue;
                OnPropertyChanged(nameof(TitleValue));
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
