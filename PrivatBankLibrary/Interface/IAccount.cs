using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using PrivatBankLibrary.Classes;

namespace PrivatBankLibrary.Interface
{
    [ServiceContract]
    public interface IAccount
    {
        [OperationContract]
        bool Authentication(string login, string password);

        [OperationContract]
        bool Registration(string login, string password, string registerDate);

        [OperationContract]
        bool EditPassword(string login, string password, string input);

        [OperationContract]
        bool UpdateAccount(string login, string password, string name, string surname, string patronymic, string email);

        [OperationContract]
        bool DeleteAccount(string login, string password);

        [OperationContract]
        string JsonData(string login, string password);
    }
}
