using Data;
using Microsoft.EntityFrameworkCore;
using Models;
using System.Linq;


namespace EcoPower_Logistics.Repository
{

    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(SuperStoreContext context) : base(context)
        {
        }

        public Customer GetMostRecentProduct()
        {
            return _context.Product.OrderByDescending(product => product.CreatedDate).FirstOrDefault();
        }
    }



}
