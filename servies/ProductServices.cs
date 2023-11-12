using Entytess;
using repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace servies
{
    public class ProductServices: IProductServices
    {
        private readonly IProductRepository _product;

        public ProductServices(IProductRepository product)
        {
            _product = product;
        }


        public async Task<IEnumerable<Product>> getAllProduct()
        {
            return await _product.getAllProduct();
        }
        //public async Task<Product> CreatNewProduct(Product product)
        //{

        //    return await _product.CreatNewProduct(product);
        //}

    }
}

