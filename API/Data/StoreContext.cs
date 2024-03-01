using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions options) : base(options)
        {
        }

        // DBSet Represents table in the DBContext.
        public DbSet<Product> Products { get; set; }
    }
}