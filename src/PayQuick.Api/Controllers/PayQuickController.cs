using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PayQuick.Api.Mappers;
using PayQuick.Contracts;
using PayQuick.Contracts.Abstractions;
using PayQuick.Domain.Abstractions;

namespace PayQuick.Api.Controllers
{
    [Route("")]
    public class PayQuickController : Controller, IPayQuick
    {
        private readonly IPayQuickService _payQuickService;

        public PayQuickController(IPayQuickService payQuickService)
        {
            _payQuickService = payQuickService;
        }
        
        [HttpPost]
        public async Task CreatePayment([FromBody]Payment payment)
        {
            await _payQuickService.ProcessPayment(Mapper.Map(payment));
        }

        [HttpPost("transactions")]
        public async Task GetTransactions([FromBody] Transaction transaction)
        {
            await _payQuickService.GetTransactions(Mapper.Map(transaction));
        }
    }
}