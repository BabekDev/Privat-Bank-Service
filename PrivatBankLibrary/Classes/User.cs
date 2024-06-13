using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using Dapper;
using Newtonsoft.Json;

namespace PrivatBankLibrary.Classes
{
    [DataContract]
    public class User
    {
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("login")]
        public string Login { get; set; }
        [JsonProperty("password")]
        public string Password { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("surname")]
        public string Surname { get; set; }
        [JsonProperty("patronymic")]
        public string Patronymic { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("registration_date")]
        public string RegisterDate { get; set; }

        public User() { }
        
        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }
        public User(string login, string password, string registerDate)
        {
            Login = login;
            Password = password;
            RegisterDate = registerDate;
        }
        
        public User(string login, string password, string name, string surname, string patronymic, string email)
        {
            Login = login;
            Password = password;
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Email = email;
        }
    }
}