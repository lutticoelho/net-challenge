using InventoryChallenge.Model;

namespace InventoryChallenge.Repository.Contract
{
    public interface IProductRepository
    {
        public void Create(Product product);
        public void Update(Product product);
        public void Delete(Product product);
        public List<Product> GetProducts(int page, int itemsPerPage, string nameFilter = "");
    }
}