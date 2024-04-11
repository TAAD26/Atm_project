using Atm.Database;
using Atm.Interfaces;

namespace Atm.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AtmContext _context;

        public CustomerRepository(AtmContext context)
        {
            _context = context;
        }

        public bool CustomerExists(Guid customerKey)
        {
            return _context.Customers.Where(o => o.CustomerKey.Equals(customerKey)).Any();
        }
    }
}