using AutoMapper;
using Cars.Domain.Contracts;
using Cars.Domain.Models;
using FirstApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstApp.Controllers
{
    public class ShopController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IShopService _shopService;

        public ShopController(IMapper mapper, IShopService shopService)
        
        {
            _mapper = mapper;
            _shopService = shopService;
        }

        // GET: Shop
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(ShopPostModel model)
        {
            var shopModel = _mapper.Map<ShopModel>(model);
            _shopService.Create(shopModel);
            return new EmptyResult();
        }
    }
}