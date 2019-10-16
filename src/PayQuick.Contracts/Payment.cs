using System;
using System.Runtime.CompilerServices;

namespace PayQuick.Contracts
{
    public class Payment
    {
        public long Account { get; set; }
        public decimal Amount { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string AdditionalAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zipcode { get; set; }
        public string Country { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string UserIp { get; set; }
        public PaymentSystem PaymentSystem { get; set; }
        public string Cardholder { get; set; }
        public string CardNumber { get; set; }
        public string CVV { get; set; }
        public int ExpiryMonth { get; set; }
        public int ExpiryYear { get; set; }
        public Guid IdempotentKey { get; set; }
    }

    public enum PaymentSystem
    {
        Mastercard,
        Visa,
        AmericanExpress
    }
}