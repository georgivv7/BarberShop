using BarberShop.Data.Configurations;
using BarberShop.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BarberShop.Data
{
    public class BarberShopDbContext : IdentityDbContext<BarberShopUser, IdentityRole, string>
    {

        public BarberShopDbContext(DbContextOptions<BarberShopDbContext> options)
            : base(options)
        {
        }

        public DbSet<Barber> Barbers { get; set; }

        public DbSet<Service> BarberServices { get; set; }

        public DbSet<Appointment> Appointments { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {           
            builder.ApplyConfiguration(new BarberConfiguration());
            builder.ApplyConfiguration(new BarberServiceConfiguration());
            builder.ApplyConfiguration(new BarberShopUserConfiguration());


            base.OnModelCreating(builder);
        }

        // private void ConfigureRelations(ModelBuilder builder)
             // => builder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
    }
}
