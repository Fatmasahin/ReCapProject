using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using ReCapProject.Core.DAL.EntityFramework;
using ReCapProject.DAL.Abstract;
using ReCapProject.Entities;
using ReCapProject.Entities.Concrete;

namespace ReCapProject.DAL.Concrete.EntityFramework
{
    public class ColorDAL :EFRepositoryBase<Color,ReCapProjectContext> ,IColorDAL
    {
        
    }
}
