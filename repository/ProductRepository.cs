using Entytess;
using Microsoft.EntityFrameworkCore;


namespace repository
{
    public class ProductRepository: IProductRepository
    {
        private readonly StoreDataBase1Context _myStoreContext;

        public ProductRepository(StoreDataBase1Context myStoreContext)
        {
            _myStoreContext = myStoreContext;
        }



        public async Task<IEnumerable<Product>> getAllProduct()
        {
           
            return await _myStoreContext.Products.ToListAsync();
        }
        //public async Task<Product> CreatNewProduct(Product product)
        //{
        //    _myStoreContext.AddAsync( product);

        //    _myStoreContext.SaveChangesAsync();
        //    return product;
        //}
    }



}



















