using InventoryChallenge.Model;
using System.Data.Entity;

namespace InventoryChallenge.Repository
{
    public class InventoryContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        //TODO: Model Mapping
    }
}
