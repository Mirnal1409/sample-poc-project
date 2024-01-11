using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tjx_pro.Controllers
{
    [ApiController]
    [Route("Countries")]
    public class CountriesController : Controller
    {
        private readonly TjxDbContext _context;
        public CountriesController(TjxDbContext context)
        {
            _context = context;
        }

        [HttpGet("GetAllCountries",Name ="GetAllCountries")]
        public IActionResult GetAllCountries()
        {
            var countries = _context.Countries.Select(c => new
            {
                c.Name,
                c.CountryCode,
                c.CurrencyCode
            });
            return Ok(countries);
        }
    }
}
