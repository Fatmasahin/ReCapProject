using System;
using System.Collections.Generic;
using ReCapProject.BLL.Abstract;
using ReCapProject.Core.Utilities.Results;
using ReCapProject.DAL.Abstract;
using ReCapProject.Entities.Concrete;

namespace ReCapProject.BLL.Concrete
{
    public class BrandManager:IBrandService
    {
        IBrandDAL _brandDAL;
        public BrandManager(IBrandDAL brandDAL)
        {
            _brandDAL = brandDAL;
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDAL.GetAll());
        }

        
    }
}
