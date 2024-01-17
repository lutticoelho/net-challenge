using InventoryChallenge.Model;
using InventoryChallenge.Repository.Contract;

namespace InventoryChallenge.Application
{
    public class ProductApplication
    {
        private readonly IProductRepository _repo;

        public ProductApplication(IProductRepository repo)
        {
            _repo = repo;
        }

        public void Create(Product product)
        {
            _repo.Create(product);
        }

        public void Delete(Product product)
        {
            _repo.Delete(product);
        }

        public List<Product> GetProducts(int page, int itemsPerPage, string nameFilter = "")
        {
            _repo.GetProducts(page, itemsPerPage, nameFilter);
        }

        public void Update(Product product)
        {
            _repo.Update(product);
        }
    }
}