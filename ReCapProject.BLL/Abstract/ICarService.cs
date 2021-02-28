using System;
using System.Collections.Generic;
using ReCapProject.Entities;
using ReCapProject.Entities.Concrete;
using ReCapProject.Entities.DTOs;

namespace ReCapProject.BLL.Abstract
{
    public interface ICarService
    {
        List<Car> GetAllCars();
        List<Car> GetCarsByBrandId(int brandId);
        Car GetCarById(int carId);

        List<Car> GetCarsByColorID(int colorID);

        void Add(Car car);

        List<CarDetailDTO> GetCarDetails();
    }
}
