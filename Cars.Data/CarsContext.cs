using Cars.Data.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace Cars.Data
{
    public  class CarsContext : IdentityDbContext<IdentityUser>
    {
        public CarsContext() : base("CarsDB") {}
        public DbSet<Car> Cars { get; set; }
    }
}
