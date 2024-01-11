using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tjx_pro.Models;

namespace tjx_pro
{
    public class TjxDbContext:DbContext
    {
        public TjxDbContext(DbContextOptions<TjxDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }


        public DbSet<Product> Products { get; set; }
        public DbSet<ExchangeRate> ExchangeRates { get; set; }
        public DbSet<Country> Countries { get; set; }
    }
}
