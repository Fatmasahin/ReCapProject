using System;
using System.Collections.Generic;
using ReCapProject.Core.DAL;
using ReCapProject.Entities;
using ReCapProject.Entities.Concrete;
using ReCapProject.Entities.DTOs;

namespace ReCapProject.DAL.Abstract
{
    public interface ICarDAL:IRepository<Car>
    {
        List<CarDetailDTO> GetCarDetails();
    }
}
