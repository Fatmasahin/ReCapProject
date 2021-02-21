using System;
using System.Collections.Generic;
using ReCapProject.Entities;

namespace ReCapProject.BLL.Abstract
{
    public interface ICarService
    {
        List<Car> GetAllCars();
        List<Car> GetCarsByBrandId(int brandId);
        Car GetCarById(int carId);
    }
}
