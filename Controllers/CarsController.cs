using AutoMapper;
using Cars.Domain.Contracts;
using FirstApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstApp.Controllers
{
    public class CarsController : Controller
    {
        private readonly ICarsService _carsService;
        private readonly IMapper _mapper;
        public CarsController(ICarsService carsService, IMapper mapper)
        {
            _carsService = carsService;
            _mapper = mapper;
        }
        public ActionResult Index(PaggingViewModel model)
        {
            var cars = _carsService.GetAll();
            if (model.Page.HasValue && model.PageSize.HasValue)
                cars = cars.Skip(model.PageSize.Value * (model.Page.Value - 1)).ToList();

            if (model.PageSize.HasValue)
                cars = cars.Take(model.PageSize.Value).ToList();

            var carsVm = _mapper.Map<List<CarViewModel>>(cars);
            var data = new GetCarViewModel
            {
                Cars = carsVm,
            };

            return View(data);
        }

        [Route("{id}")]
        public ActionResult GetById(int id)
        {
            var car = _carsService.GetAll().FirstOrDefault(x => x.Id == id);

            var carVM = _mapper.Map<CarViewModel>(car);

            return View(carVM);
        }
    }
}