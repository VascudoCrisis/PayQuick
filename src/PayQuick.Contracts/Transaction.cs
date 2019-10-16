using System;

namespace PayQuick.Contracts
{
    public class Transaction
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public TransactionStatus Status { get; set; }

    }

    public enum TransactionStatus
    {
        Approved,
        Declined
    }
}