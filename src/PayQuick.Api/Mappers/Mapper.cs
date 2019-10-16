using PayQuick.Contracts;
using PayQuick.Domain.Models;

namespace PayQuick.Api.Mappers
{
    public static class Mapper
    {
        public static PaymentModel Map(Payment payment)
        {
            return new PaymentModel
            {
                Account = payment.Account,
                Amount = payment.Amount,
                FirstName = payment.FirstName,
                LastName = payment.LastName,
                Email = payment.Email,
                Phone = payment.Phone,
                Address = payment.Address,
                AdditionalAddress = payment.AdditionalAddress,
                City = payment.City,
                State = payment.State,
                Zipcode = payment.Zipcode,
                Country = payment.Country,
                DateOfBirth = payment.DateOfBirth,
                UserIp = payment.UserIp,
                PaymentSystem = (Domain.Models.PaymentSystem)payment.PaymentSystem,
                Cardholder = payment.Cardholder,
                CardNumber = payment.CardNumber,
                CVV = payment.CVV,
                ExpiryMonth = payment.ExpiryMonth,
                ExpiryYear = payment.ExpiryYear,
                IdempotentKey = payment.IdempotentKey
            };
        }

        public static TransactionModel Map(Transaction transaction)
        {
            return new TransactionModel
            {
                StartDate = transaction.StartDate,
                EndDate = transaction.EndDate,
                Status = (Domain.Models.TransactionStatus)transaction.Status
            };
        }
    }
}