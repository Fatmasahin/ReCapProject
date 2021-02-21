using System;
using ReCapProject.BLL.Abstract;
using ReCapProject.DAL.Abstract;

namespace ReCapProject.BLL.Concrete
{
    public class ColorManager:IColorService
    {
        IColorDAL _colorDAL;
        public ColorManager(IColorDAL colorDAL)
        {
            _colorDAL = colorDAL;
        }
       
    }
}
