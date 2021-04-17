using System;
using System.Collections.Generic;
using FluentValidation;
using ReCapProject.BLL.Abstract;
using ReCapProject.BLL.Constants;
using ReCapProject.BLL.ValidationRules;
using ReCapProject.Core.Aspects.Autofac.Validation;
using ReCapProject.Core.CrossCuttingConcerns.Validation;
using ReCapProject.Core.Utilities.Business;
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
        IBrandService _brandService; 
        public CarManager(ICarDAL carDAL,IBrandService brandService)
        {
            _carDAL = carDAL;
            _brandService =brandService;
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
        [SecuredOperation]
        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {
           IResult result= BusinessRules.Run(CheckSameBrandCount(car.BrandId),CheckSameCarNameAndSameBrandId(car),CheckBrandCount(car.BrandId));
            if (result!=null)
            {
                return result;
            }
            _carDAL.Add(car);
            return new SuccessResult(Messages.CarAdded);
        }

        private IResult CheckSameBrandCount(int brandId)
        {
            var brandCount=_carDAL.GetAll(i => i.BrandId == brandId).Count;
            if (brandCount>10)
            {
                return new ErrorResult(Messages.CarBrandCountLimitError);
            }
            return new SuccessResult();
        }

        private IResult CheckSameCarNameAndSameBrandId(Car car)
        {
           var carInfo= _carDAL.GetAll(i=>i.Name==car.Name && i.BrandId==car.BrandId).Count;
            if (carInfo>0)
            {
                return new ErrorResult(Messages.SameCarNameAndSameBrandId);

            }
            return new SuccessResult();
        }

        private IResult CheckBrandCount(int brandId)
        {
            if (_brandService.GetAll().Data.Count > 15)
            {
                return new ErrorResult(Messages.CategoryLimitExceded);
            } return new SuccessResult();
        }

		public IDataResult<List<CarDetailDTO>> GetCarDetails()
		{
            return new SuccessDataResult<List<CarDetailDTO>>(_carDAL.GetCarDetails());
		}

      

    }
}
