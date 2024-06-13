using System.ServiceModel;

namespace PrivatBankLibrary.Interface
{
    [ServiceContract]
    public interface ICard
    {
        [OperationContract]
        void CreateCard();

        [OperationContract]
        void DeleteCard();

        [OperationContract]
        void Transfer();
    }
}