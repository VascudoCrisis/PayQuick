using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using PayQuick.Domain.Abstractions;
using PayQuick.Domain.Models;
using PayQuick.Domain.Settings;

namespace PayQuick.Domain
{
    internal class PayQuickService : IPayQuickService
    {
        private readonly IHttpClientFactory _clientFactory;
        private readonly Uri _baseUrl;
        private string _apiKey;

        public PayQuickService(IHttpClientFactory clientFactory, IOptions<PayQuickSettings> settings)
        {
            _clientFactory = clientFactory;
            _baseUrl = new Uri(settings.Value.Url);
            _apiKey = settings.Value.ApiKey;
        }
        
        public async Task ProcessPayment(PaymentModel paymentModel)
        {
            var client = _clientFactory.CreateClient();

            paymentModel.ApiKey = _apiKey;
            var res = await client.PostAsync(new Uri(_baseUrl, "processPayment"), new FormUrlEncodedContent(paymentModel.ToDictionary()));
        }

        public async Task GetTransactions(TransactionModel transactionModel)
        {
            var client = _clientFactory.CreateClient();

            transactionModel.ApiKey = _apiKey;
            var res = await client.PostAsync(new Uri(_baseUrl, "getTransactions"), new FormUrlEncodedContent(transactionModel.ToDictionary()));
        }
    }
}