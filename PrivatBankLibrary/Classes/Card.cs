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
    public class Card
    {
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("id_user")]
        public long IdUser { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("surname")]
        public string Surname { get; set; }
        [JsonProperty("patronymic")]
        public string Patronymic { get; set; }
        [JsonProperty("money")]
        public double Money { get; set; }
        [JsonProperty("credit")]
        public double Credit { get; set; }
        [JsonProperty("type_card")]
        public string TypeCard { get; set; }
        [JsonProperty("card_number")]
        public string CardNumber { get; set; }
        [JsonProperty("cvv")]
        public byte Cvv { get; set; }
        [JsonProperty("type_cvv")]
        public string TypeCvv { get; set; }
        [JsonProperty("pin")]
        public ushort Pin { get; set; }
        [JsonProperty("credit_limit")]
        public double CreditLimit { get; set; }
        [JsonProperty("cash_back")]
        public double СashBack { get; set; }

        public Card(string name, string surname, string patronymic, double money, double credit, string typeCard, 
            string cardNumber, byte cvv, string typeCvv, ushort pin, double creditLimit, double cashBack)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Money = money;
            Credit = credit;
            TypeCard = typeCard;
            CardNumber = cardNumber;
            Cvv = cvv;
            TypeCvv = typeCvv;
            Pin = pin;
            CreditLimit = creditLimit;
            СashBack = cashBack;
        }
    }
}