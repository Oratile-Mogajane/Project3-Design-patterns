using Data;
using Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EcoPower_Logistics.Repository
{
    public class    CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(SuperStoreContext context) : base(context)
        {
        }

        public Customer GetMostRecentCustomer()
        {
            return _context.Customer.OrderByDescending(customer => customer.CreatedDate).FirstOrDefault();
        }
    }


    }






