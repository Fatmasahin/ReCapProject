using System;
using System.Collections.Generic;
using ReCapProject.BLL.Abstract;
using ReCapProject.DAL.Abstract;
using ReCapProject.Entities;

namespace ReCapProject.BLL.Concrete
{
    public class CarManager : ICarService
    {
        ICarDAL _carDAL;
        public CarManager(ICarDAL carDAL)
        {
            _carDAL = carDAL;
        }
        public List<Car> GetAllCars()
        {
            return _carDAL.GetAll();
        }

        public Car GetCarById(int carId)
        {
            return _carDAL.Get(i=>i.ID==carId);
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDAL.GetAll(i=>i.BrandId==brandId);
        }
    }
}
