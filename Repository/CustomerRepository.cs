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

        public string Login(string userId, string password)
        {
            if (String.IsNullOrEmpty(userId)) throw new ArgumentNullException(nameof(userId));
            if (String.IsNullOrEmpty(password)) throw new ArgumentNullException(nameof(password));
            var customer = _context.Customers.FirstOrDefault(c => c.UserId == userId && c.Password == password);
            if (customer == null) throw new Exception("Invalid login");
            return customer.CustomerKey.ToString();
        }
    }
}
