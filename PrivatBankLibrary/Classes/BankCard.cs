using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;

namespace PrivatBankLibrary.Classes
{
    [DataContract]
    [Serializable]
    public class BankCard
    {
        private readonly Card _card;

        public BankCard(Card card) => _card = card;



        public string JsonData() => JsonConvert.SerializeObject(_card);
    }
}