using PrivatBankLibrary.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace PrivatBankLibrary.Classes
{
    [DataContract]
    [Serializable]
    public class Connection
    {
        private const string AccountService = "http://babek2021-001-site1.ctempurl.com//AccountService.svc";
        private const string CardService = "http://localhost:49891/CardService.svc";
        public static IAccount Account() => new ChannelFactory<IAccount>(new BasicHttpBinding(), new EndpointAddress(new Uri(AccountService))).CreateChannel();
        public static ICard Card() => new ChannelFactory<ICard>(new BasicHttpBinding(), new EndpointAddress(new Uri(CardService))).CreateChannel();
    }
}
