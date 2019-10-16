using System;

namespace PayQuick.Domain.Models
{
    public class TransactionModel : ModelBase
    {
        public DateTime StartDate 
        {
            set => SetPropertyValue("startDate", value.ToString("MMddyyyy"));
        }
        public DateTime EndDate 
        {
            set => SetPropertyValue("endDate", value.ToString("MMddyyyy"));
        }
        public TransactionStatus Status 
        {
            set => SetPropertyValue("status", value);
        }
    }

    public enum TransactionStatus
    {
        Approved,
        Declined
    }
}