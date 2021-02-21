using System;
using ReCapProject.BLL.Abstract;
using ReCapProject.DAL.Abstract;

namespace ReCapProject.BLL.Concrete
{
    public class BrandManager:IBrandService
    {
        IBrandDAL _brandDAL;
        public BrandManager(IBrandDAL brandDAL)
        {
            _brandDAL = brandDAL;
        }
    }
}
