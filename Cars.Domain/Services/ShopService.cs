using AutoMapper;
using Cars.Data.Contracts;
using Cars.Data.Models;
using Cars.Domain.Contracts;
using Cars.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Domain.Services
{
    public class ShopService : IShopService
    {
        private readonly IMapper _mapper;
        private readonly IShopRepository _shopRepository;
        public ShopService(IMapper mapper, IShopRepository shopRepository)
        {
            _mapper = mapper;
            _shopRepository = shopRepository;
        }

        public void Create(ShopModel model)
        {
            var shop = _mapper.Map<Shop>(model);
            _shopRepository.Create(shop);
        }
    }
}
