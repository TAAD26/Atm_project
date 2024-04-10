using Atm_Project.Model;
using Microsoft.EntityFrameworkCore;

namespace Atm_Project.Database
{
    public class AtmContext : DbContext
    {
        DbSet<Customer> Customers { get; set; }
    }
}
