using Atm.Database;
using Atm.Interfaces;
using Atm.Model;

namespace Atm.Repository
{
    public class CustomerRepository(AtmContext atmContext) : ICustomerRepository
    {
        public void CreateCustomer(Customer customer)
        {
            atmContext.Customers.Add(customer);
            atmContext.SaveChanges();
        }
    }
}
