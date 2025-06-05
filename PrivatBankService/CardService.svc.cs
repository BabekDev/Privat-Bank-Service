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
            // Implementation of card creation should be added here
        }

        public void DeleteCard()
        {
            // Implementation of card deletion should be added here
        }

        public void Transfer()
        {
            // Implementation of card transfer should be added here
        }
    }
}