using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace tjx_pro.Models
{
    public class ExchangeRate
    {
        [Key]
        public int Id { get; set; }
        public decimal Rate { get; set; }
        public string CurrencyCode { get; set; }
        public DateTime ValidFromDate { get; set; }
        public DateTime? ValidToDate { get; set; }
    }
}
