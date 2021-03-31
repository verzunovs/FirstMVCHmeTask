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
        public ActionResult Index()
        {
            var cars = _carsService.GetAll();

            var carsVm = _mapper.Map<List<CarViewModel>>(cars);
            var data = new GetCarViewModel
            {
                Cars = carsVm,
            };

            return View(data);
        }

        public ActionResult GetById(int id)
        {
            var car = _carsService.GetAll().FirstOrDefault(x => x.Id == id);

            var carVM = _mapper.Map<CarViewModel>(car);

            return View(carVM);
        }
    }
}