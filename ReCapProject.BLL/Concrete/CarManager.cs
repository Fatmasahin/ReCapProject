using System;
using System.Collections.Generic;
using ReCapProject.BLL.Abstract;
using ReCapProject.DAL.Abstract;
using ReCapProject.Entities;
using ReCapProject.Entities.Concrete;
using ReCapProject.Entities.DTOs;

namespace ReCapProject.BLL.Concrete
{
    public class CarManager : ICarService
    {
        ICarDAL _carDAL;
        IBrandDAL _brandDAL;
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

		public List<Car> GetCarsByColorID(int colorID)
		{
            return _carDAL.GetAll(i=>i.ColorId==colorID);
		}

        public void Add(Car car)
        {
			if (CarNameLengthControl(car.Name) && CarPriceMustPositive(car.DailyPrice))
			{
                 _carDAL.Add(car);
			}
        }


        public bool CarNameLengthControl(string name)
		{
            return name.Length >= 2;
		}

        public bool CarPriceMustPositive(decimal price)
		{
            return price > 0;
		}

		public List<CarDetailDTO> GetCarDetails()
		{
            return _carDAL.GetCarDetails();
		}
	}
}
