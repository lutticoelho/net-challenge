using InventoryChallenge.Model;
using InventoryChallenge.Repository.Contract;

namespace InventoryChallenge.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly InventoryContext _context;

        public ProductRepository(InventoryContext context)
        {
            _context = context;
        }

        public void Create(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProducts(int page, int itemsPerPage, string nameFilter = "")
        {
            var products = _context.Products;

            if (!string.IsNullOrWhiteSpace(nameFilter))
            {
                products.Where(p => p.Name.Contains(nameFilter));
            }

            return products.Skip(page * itemsPerPage).Take(itemsPerPage).ToList();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}