using Microsoft.EntityFrameworkCore;
using WashingLaundary.Models;

namespace WashingLaundary.Data
{
    public class CustomerDbContext: DbContext
    {
        public CustomerDbContext(DbContextOptions options): base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }


    }
}
