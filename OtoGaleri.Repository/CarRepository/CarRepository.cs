using Model;
using OtoGaleri.Core.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace OtoGaleri.Repository.CarRepository
{
    public class CarRepository : Repository<Car, Guid>, ICarRepository
    {

    }
}
