using Model;
using OtoGaleri.Repository.CarRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OtoGaleri.Service.CarService
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;

        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public void AddCar(Car car)
        {
            _carRepository.Add(car);
        }

        public void DeleteCar(Car car)
        {
            _carRepository.Delete(car);
        }

        public void DeleteCarById(Guid carId)
        {
            _carRepository.Delete(carId);
        }

        public List<Car> GetAllCars()
        {
            return _carRepository.GetAll().ToList();
        }

        public void UpdateCar(Car car)
        {
           _carRepository.Update(car);
        }
    }
}
