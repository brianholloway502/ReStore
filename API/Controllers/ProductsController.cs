using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {

        private readonly StoreContext _context;

        public ProductsController(StoreContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts() 
        {
            // asynchronous code.
            return await _context.Products.ToListAsync();

            // synchronous code.
            //var products = _context.Products.ToList();
            //return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task <ActionResult<Product>> GetProduct(int id)
        {
            // asynchronous code.
            return await _context.Products.FindAsync(id);

            // Synchronous code
            //return _context.Products.Find(id);
        }

        
    }
}