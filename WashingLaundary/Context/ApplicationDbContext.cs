using Microsoft.EntityFrameworkCore;
using WashingLaundary.Entity;

namespace WashingLaundary.Context
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Clothes> Clothes { get; set; }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Clothes>()
                .HasOne(clothes => clothes.Customer)
                .WithMany(customer => customer.Clothes)
                .HasForeignKey(Clothes => Clothes.CustomerID);
        }

    }
  
}
