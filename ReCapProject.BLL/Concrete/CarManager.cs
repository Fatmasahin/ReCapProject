using System;
using System.Collections.Generic;
using ReCapProject.BLL.Abstract;
using ReCapProject.BLL.Constants;
using ReCapProject.Core.Utilities.Results;
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

		
		public IDataResult<List<Car>> GetAllCars()
        {
            return new SuccessDataResult<List<Car>>(_carDAL.GetAll());
        }

        public IDataResult<Car> GetCarById(int carId)
        {
            return new SuccessDataResult<Car>(_carDAL.Get(i => i.ID == carId));
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>(_carDAL.GetAll(i => i.BrandId == brandId));
        }

		public IDataResult<List<Car>> GetCarsByColorID(int colorID)
		{
            return new SuccessDataResult<List<Car>>(_carDAL.GetAll(i => i.ColorId == colorID));
		}

        public IResult Add(Car car)
        {
			if (CarNameLengthControl(car.Name) && CarPriceMustPositive(car.DailyPrice))
			{
                _carDAL.Add(car);
             return new SuccessResult(Messages.ProductAdded);
			}
            return new ErrorResult();
        }

		public IDataResult<List<CarDetailDTO>> GetCarDetails()
		{

            return new SuccessDataResult<List<CarDetailDTO>>(_carDAL.GetCarDetails());
		}

        public bool CarNameLengthControl(string name)
        {
            return name.Length >= 2;
        }

        public bool CarPriceMustPositive(decimal price)
        {
            return price > 0;
        }

    }
}
