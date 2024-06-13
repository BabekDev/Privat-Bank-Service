using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using PrivatBankLibrary;
using PrivatBankLibrary.Classes;
using PrivatBankLibrary.Interface;

namespace PrivatBankService
{
    public class CardService : ICard
    {
        public void CreateCard()
        {
            throw new NotImplementedException();
        }

        public void DeleteCard()
        {
            throw new NotImplementedException();
        }

        public void Transfer()
        {
            throw new NotImplementedException();
        }
    }
}