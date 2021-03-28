using Cars.Data.Contracts;
using Cars.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Data.Repositories
{
    public class CarsRepository : ICarRepository
    {
        public IReadOnlyCollection<Car> GetAll()
        {
            using(var ctx = new CarsContext())
            {
                return ctx.Cars.AsNoTracking().ToList();
            }

        }
    }
}
