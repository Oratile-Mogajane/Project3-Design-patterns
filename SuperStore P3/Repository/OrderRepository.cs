using Data;
using Models;
using System.Linq;

namespace EcoPower_Logistics.Repository
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(SuperStoreContext context) : base(context)
        {
        }

        public Order GetMostRecentOrder()
        {
            return _context.Order.OrderByDescending(order => order.CreatedDate).FirstOrDefault();
        }
    }

}
