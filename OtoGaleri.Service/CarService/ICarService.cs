using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OtoGaleri.Service.CarService
{
    public interface ICarService
    {
        void AddCar(Car car);
        void DeleteCar(Car car);

        void DeleteCarById(Guid carId);

        List<Car> GetAllCars();

        void UpdateCar(Car car);
    }
}
