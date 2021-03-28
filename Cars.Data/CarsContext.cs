using Cars.Data.Models;
using System.Data.Entity;

namespace Cars.Data
{
    public  class CarsContext : DbContext
    {
        public CarsContext() : base("CarShop") {}
        public DbSet<Car> Cars { get; set; }
    }
}
