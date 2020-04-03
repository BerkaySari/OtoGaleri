using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model;
using OtoGaleri.Service.CarService;

namespace OtoGaleri.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarProfileController : ControllerBase
    {
        private readonly ICarService _carService;

        public CarProfileController(ICarService carService)
        {
            _carService = carService;
        }


        [HttpPost("[action]")]
        public IActionResult AddCar(Car car)
        {
            _carService.AddCar(car);
            return Ok();
        }

        [HttpGet("[action]")]
        public IActionResult DeleteCar()
        {
            return Ok();
        }

        [HttpGet("[action]")]
        public IActionResult GetCar()
        {
            return Ok();
        }

        [HttpGet("[action]")]
        public IActionResult GetAllCars()
        {
            var cars = _carService.GetAllCars();
            return Ok(cars);
        }
    }
}
