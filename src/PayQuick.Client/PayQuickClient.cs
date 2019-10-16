using System.Threading.Tasks;
using PayQuick.Contracts;
using PayQuick.Contracts.Abstractions;

namespace PayQuick.Client
{
    public class PayQuickClient : IPayQuick
    {
        public Task CreatePayment(Payment payment)
        {
            throw new System.NotImplementedException();
        }

        public Task GetTransactions(Transaction transaction)
        {
            throw new System.NotImplementedException();
        }
    }
}