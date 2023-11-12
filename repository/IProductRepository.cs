using Entytess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> getAllProduct();
        //Task<Product> CreatNewProduct(Product product);
    }
}
