using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using PrivatBankLibrary;
using PrivatBankLibrary.Classes;
using PrivatBankLibrary.Interface;

namespace PrivatBankService
{
    [DataContract]
    [Serializable] 
    public class AccountService : IAccount
    {
        public bool Authentication(string login, string password) => new BankAccount(new User(login, password)).Authentication();
        public bool Registration(string login, string password, string registerDate) => new BankAccount(new User(login, BCrypt.Net.BCrypt.HashPassword(password), registerDate)).Registration();
        public bool EditPassword(string login, string password, string input) => new BankAccount(new User(login, password)).EditPassword(BCrypt.Net.BCrypt.HashPassword(input));
        public bool UpdateAccount(string login, string password, string name, string surname, string patronymic, string email) => 
            new BankAccount(new User(login, password, name, surname, patronymic, email)).UpdateAccount();
        public bool DeleteAccount(string login, string password) => new BankAccount(new User(login, password)).DeleteAccount();
        public string JsonData(string login, string password) => new BankAccount(new User(login, password)).JsonData();
    }
}