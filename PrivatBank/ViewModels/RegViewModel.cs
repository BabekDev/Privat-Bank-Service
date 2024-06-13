using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using PrivatBankLibrary.Interface;
using PrivatBankLibrary.Classes;
using System.Windows;
using System.Globalization;

namespace PrivatBank.ViewModels
{
    public class RegViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string _login;
        private string _password;
        private string _rePassword;

        public string Login
        {
            get => _login;
            set
            {
                _login = value;
                OnPropertyChanged(nameof(Login));
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        public string RePassword
        {
            get => _rePassword;
            set
            {
                _rePassword = value;
                OnPropertyChanged(nameof(RePassword));
            }
        }

        public ICommand CommandRegister => new RelayCommand(Registration);

        private async void Registration() => await Task.Run(() =>
        {
            MessageBox.Show(Connection.Account().Registration(_login, _password, DateTime.Now.ToString(CultureInfo.InvariantCulture)) ? "Successful registration" : "This login already exists");
        });

        private void OnPropertyChanged([CallerMemberName] string prop = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
    }
}
