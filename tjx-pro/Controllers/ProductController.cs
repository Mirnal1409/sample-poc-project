using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tjx_pro.Controllers
{
    [ApiController]
    [Route("Products")]
    public class ProductController : Controller
    {
        private readonly TjxDbContext _context;


        public ProductController(TjxDbContext context)
        {
            _context = context;
        }

        [HttpGet("GetAllProducts",Name ="GetAllProducts")]
        public IActionResult GetAllProducts()
        {
            var products = _context.Products.ToList();
            return Ok(products);
        }
    }
}
