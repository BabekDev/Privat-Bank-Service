using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Newtonsoft.Json;
using PrivatBankLibrary.Interface;

namespace PrivatBankLibrary.Classes
{
    public class BankAccount
    {
        private readonly User _user;
        public BankAccount(User user) => _user = user;
        public bool Authentication() => DapperInquiry.Account.GetUsers().Any(user => _user.Login.Equals(user.Login) && BCrypt.Net.BCrypt.Verify(_user.Password, user.Password));

        private bool CheckAccount() => DapperInquiry.Account.GetUsers()
                .Any(user => _user.Login.Equals(user.Login) && BCrypt.Net.BCrypt.Verify(_user.Password, user.Password));

        public bool Registration()
        {
            if (DapperInquiry.Account.GetUsers().Any(user => _user.Login.Equals(user.Login))) return false;
            DapperInquiry.Account.Create(_user);
            return true;
        }

        public bool EditPassword(string input)
        {
            if (!CheckAccount()) return false;
            DapperInquiry.Account.UpdatePassword(_user, input);
            return true;
        }
        
        public bool UpdateAccount()
        {
            if (!CheckAccount()) return false;
            DapperInquiry.Account.UpdateAccount(_user);
            return true;
        }

        public bool DeleteAccount()
        {

            if (!CheckAccount()) return false;
            DapperInquiry.Account.Delete(_user.Login);
            return true;
        }

        public string JsonData() => JsonConvert.SerializeObject(DapperInquiry.Account.JsonData(_user.Login));
    }
}