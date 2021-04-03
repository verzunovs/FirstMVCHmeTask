using Cars.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Data.Contracts
{
    public interface IShopRepository
    {
        void Create(Shop model);
    }
}
