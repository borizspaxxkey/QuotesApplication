using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace QuotesApplication
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public ICommand LoginCommand { get; set; }
        private string _userName;
        private INavigation _navigation;

        public string UserName
        {
            get { return _userName; }
            set
            {
                _userName = value;
                OnPropertyChanged("UserName");
            }
        }

        public MainViewModel(INavigation navigation)
        {
            LoginCommand = new Command(Login);
            _navigation = navigation;
        }

        private void Login()
        {
            _navigation.PushAsync(new SamplePage(_userName));
            //App.Current.MainPage.DisplayAlert("Hi", _userName, "Alright");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
