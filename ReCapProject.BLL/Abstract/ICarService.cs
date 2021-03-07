using System;
using System.Collections.Generic;
using ReCapProject.Core.Utilities.Results;
using ReCapProject.Entities;
using ReCapProject.Entities.Concrete;
using ReCapProject.Entities.DTOs;

namespace ReCapProject.BLL.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAllCars();
        IDataResult<List<Car>> GetCarsByBrandId(int brandId);
        IDataResult< Car> GetCarById(int carId);

        IDataResult<List<Car>> GetCarsByColorID(int colorID);

        IResult Add(Car car);

        IDataResult<List<CarDetailDTO>> GetCarDetails();
    }
}
