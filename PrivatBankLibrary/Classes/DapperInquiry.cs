using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Text;
using Dapper;

namespace PrivatBankLibrary.Classes
{
    [DataContract]
    [Serializable]
    public static class DapperInquiry
    {
        private static readonly string _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public static class Account
        {
            public static IEnumerable<User> GetUsers()
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    return dbConnection.Query<User>($"SELECT * FROM Users").ToList();
                }
            }
        
            public static void Create(User user)
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    dbConnection.Query<User>($"INSERT INTO Users (Login, Password, RegisterDate) values('{user.Login}', '{user.Password}', '{user.RegisterDate}')");
                }
            }
        
            public static void UpdatePassword(User user, string input)
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    dbConnection.Query<User>($"UPDATE Users SET Password='{input}' WHERE Login='{user.Login}'");
                }
            }
        
            public static void UpdateAccount(User user)
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    dbConnection.Query<User>($"UPDATE Users SET Name = '{user.Name}', Surname='{user.Surname}', Patronymic='{user.Patronymic}', Email='{user.Email}' WHERE Login='{user.Login}'");
                }
            }
        
            public static void Delete(string input)
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    dbConnection.Query<User>($"DELETE FROM Users WHERE Login='{input}'");
                }
            }

            public static IEnumerable<User> JsonData(string input)
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    return dbConnection.Query<User>($"SELECT * FROM Users WHERE Login='{input}'").ToList();
                }
            }
        }
        
        public static class Card
        {
            
        }
    }
}