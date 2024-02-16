using Microsoft.EntityFrameworkCore;
using WashingLaundary.Models;

namespace WashingLaundary.Data
{
    public class CustomerDbContext: DbContext
    {
        public CustomerDbContext(DbContextOptions<CustomerDbContext> options): base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Clothes> Clothes { get; set; }

       


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Clothes>()
                .HasOne(cloth => cloth.customer)
                .WithMany(customer => customer.Clothes)
                .HasForeignKey(clothes => clothes.CustomerId);
        }

    }
}
