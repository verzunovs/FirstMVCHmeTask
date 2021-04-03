using Cars.Data.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace Cars.Data
{
    public  class CarsContext : IdentityDbContext<IdentityUser>
    {
        public CarsContext() : base("CarShop") {}
        public DbSet<Car> Cars { get; set; }
        public DbSet<Shop> Shops { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Car>()
                .Property(x => x.UserId)
                .IsOptional();
            modelBuilder.Entity<Car>()
                .HasRequired(x => x.Shop)
                .WithMany(x => x.Cars)
                .HasForeignKey(x => x.ShopId)
                .WillCascadeOnDelete(false);
        }
    }
}
