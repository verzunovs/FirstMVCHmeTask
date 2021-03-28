using AutoMapper;
using Cars.Data.Contracts;
using Cars.Domain.Contracts;
using Cars.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Domain.Services
{
    public class CarsService : ICarsService
    {
        private readonly ICarRepository _carRepository;
        private readonly IMapper _mapper;

        public CarsService(ICarRepository carRepository, IMapper maper)
        {
            _carRepository = carRepository;
            _mapper = maper;
        }

        public IReadOnlyCollection<CarModel> GetAll()
        {
            var cars = _carRepository.GetAll();
            var result = _mapper.Map<IReadOnlyCollection<CarModel>>(cars);
            return result;
        }
    }
}
