using System.Threading.Tasks;

namespace SqliteDapper.Demo.ProductMaster
{
    public interface IProductRepository
    {
        Task Create(Product product);
    }
}