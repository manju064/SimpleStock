using System.Data.Entity;
using Data.Entities;

namespace Data
{
    public class SimpleStockContext : DbContext
    {
        public DbSet<Stock> Stocks { get; set; }
    }
}
