using System.Collections.Generic;
using System.Threading.Tasks;

namespace SqliteDapper.Demo.ProductMaster
{
    public interface IProductProvider
    {
        Task<IEnumerable<Product>> Get();
    }
}