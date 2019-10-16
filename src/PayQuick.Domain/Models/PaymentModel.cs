using System;
using System.Collections.Generic;
using System.Security;

namespace PayQuick.Domain.Models
{
    public class PaymentModel : ModelBase
    {
        
        public long Account 
        {
            set => SetPropertyValue(nameof(Account), value);
        }
        
        public decimal Amount 
        {
            set => SetPropertyValue("amount", value);
        }
        
        public string FirstName 
        {
            set => SetPropertyValue("firstName", value);
        }
        
        public string LastName 
        {
            set => SetPropertyValue("lastName", value);
        }
        
        public string Email 
        {
            set => SetPropertyValue("email", value);
        }
        
        public string Phone 
        {
            set => SetPropertyValue("phone", value);
        }
        public string Address 
        {
            set => SetPropertyValue("address", value);
        }
        public string AdditionalAddress 
        {
            set => SetPropertyValue("address2", value);
        }
        public string City 
        {
            set => SetPropertyValue("city", value);
        }

        public string State
        {
            set => SetPropertyValue("state", value);
        }
        
        public int Zipcode 
        {
            set => SetPropertyValue("zipCode", value);
        }
        
        public string Country 
        {
            set => SetPropertyValue("country", value);
        }
        
        public DateTime DateOfBirth 
        {
            set => SetPropertyValue("DOB", value.ToString("MMddyyyy"));
        }
        
        public string UserIp 
        {
            set => SetPropertyValue("UIP", value);
        }
        
        public PaymentSystem PaymentSystem 
        {
            set => SetPropertyValue("payBy", value);
        }
        
        public string Cardholder 
        {
            set => SetPropertyValue("cardName", value);
        }
        
        public string CardNumber 
        {
            set => SetPropertyValue("cardNo", value);
        }
        
        public string CVV 
        {
            set => SetPropertyValue("CVV", value);
        }
        public int ExpiryMonth 
        {
            set => SetPropertyValue("expiryMonth", value);
        }
        public int ExpiryYear 
        {
            set => SetPropertyValue("expiryYear", value);
        }
        
        public Guid IdempotentKey { get; set; }
    }
    
    public enum PaymentSystem
    {
        mastercard,
        visa,
        americanexpress
    }
}