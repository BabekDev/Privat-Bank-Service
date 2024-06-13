using GalaSoft.MvvmLight.Command;
using PrivatBankLibrary.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace PrivatBank.ViewModels
{
    public class AuthViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string _login;
        private string _password;

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


        public ICommand CommandAuth => new RelayCommand(Authentication);

        private async void Authentication() => await Task.Run(() =>
        {
            string json = Connection.Account().JsonData(_login, _password);
            MessageBox.Show(Connection.Account().Authentication(_login, _password).ToString());
        });

        private void OnPropertyChanged([CallerMemberName] string prop = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
    }
}
