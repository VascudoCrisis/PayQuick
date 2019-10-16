using System.Threading.Tasks;

namespace PayQuick.Contracts.Abstractions
{
    public interface IPayQuick
    {
        Task CreatePayment(Payment payment);
        Task GetTransactions(Transaction transaction);
    }
}