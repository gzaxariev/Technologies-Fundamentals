
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CarWebSystem.Models;

namespace CarWebSystem.Data
{
    public class CarSystemDbContext : IdentityDbContext<User>
    {
        public CarSystemDbContext(DbContextOptions<CarSystemDbContext> options)
            : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Car>()
                .HasOne(c => c.User)
                .WithMany(u => u.Cars)
                .HasForeignKey(c => c.UserId);

            base.OnModelCreating(builder);
           
        }
    }
}
