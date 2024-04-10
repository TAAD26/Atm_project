using Atm.Model;
using Microsoft.EntityFrameworkCore;

namespace Atm.Database
{
    public class AtmContext : DbContext
    {
        DbSet<Customer> Customers { get; set; }
        DbSet<Account> Accounts { get; set; }
        DbSet<Transaction> Transactions { get; set; }

        public AtmContext(DbContextOptions<AtmContext> options) : base(options)
        {
        }
    }
}
