using Cars.Data.Models;
using Cars.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Domain.Contracts
{
    public interface IShopService
    {
        void Create(ShopModel model);
    }
}
