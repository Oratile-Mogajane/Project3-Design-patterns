using Data;
using Models;
using System.Linq;
using static EcoPower_Logistics.Repository.OrderDetailRepository;


namespace EcoPower_Logistics.Repository
{
    
        public class OrderDetailRepository : GenericRepository<OrderDetail>, IOrderDetailRepository
        {
            public OrderDetailRepository(SuperStoreContext context) : base(context)
            {
            }

            public OrderDetail GetMostRecentOrderDetail()
            {
                return _context.OrderDetail.OrderByDescending(OrderDetail => OrderDetail.CreatedDate).FirstOrDefault();
            }
        }

    
}
