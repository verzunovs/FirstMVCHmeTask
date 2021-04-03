using Cars.Data.Contracts;
using Cars.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Data.Repositories
{
    public class ShopRepository : IShopRepository
    {
        public void Create(Shop model)
        {
            using(var ctx = new CarsContext())
            {
                ctx.Shops.Add(model);
                ctx.SaveChanges();
            }
        }
    }
}
