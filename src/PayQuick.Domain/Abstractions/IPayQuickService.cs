using System.Threading.Tasks;
using PayQuick.Domain.Models;

namespace PayQuick.Domain.Abstractions
{
    public interface IPayQuickService
    {
        Task ProcessPayment(PaymentModel paymentModel);
        Task GetTransactions(TransactionModel transactionModel);
    }
}