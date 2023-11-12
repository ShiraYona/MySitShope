using Entytess;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace servies
{
    public interface IProductServices
    {
        Task<IEnumerable<Product>> getAllProduct();


        //Task<Product> CreatNewProduct(Product product);
    }
}
