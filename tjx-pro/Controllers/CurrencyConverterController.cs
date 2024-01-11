using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tjx_pro.Models;

namespace tjx_pro.Controllers
{
    [ApiController]
    [Route("CurrencyConverter")]
    public class CurrencyConverterController : Controller
    {
        private readonly TjxDbContext _context;
        public CurrencyConverterController(TjxDbContext context)
        {
            _context = context;
        }

        [HttpGet("GetExchangeRate")]
        public IActionResult GetExchangeRate(string fromCurrency,string toCurrency)
        {

            var fromExchangeRate = GetExchangeRate(fromCurrency);
            var toExchangeRate = GetExchangeRate(toCurrency);
            if(fromExchangeRate == null && toExchangeRate == null)
            {
                return BadRequest("Invalid currency code");

            }
            var convertedAmount = 1 * toExchangeRate.Rate / fromExchangeRate.Rate;

            return Ok(new
            {
                amount = convertedAmount,
                fromCurrency = fromExchangeRate,
                toCurrency = toExchangeRate
            });
        }

        private ExchangeRate GetExchangeRate(string currencyCode)
        {
            return _context.ExchangeRates
                .OrderByDescending(x => x.ValidFromDate)
                .FirstOrDefault(y => y.CurrencyCode == currencyCode && y.ValidFromDate <= DateTime.Now);
        }
    }
}
