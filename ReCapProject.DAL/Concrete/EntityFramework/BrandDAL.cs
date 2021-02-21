using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using ReCapProject.Core.DAL.EntityFramework;
using ReCapProject.DAL.Abstract;
using ReCapProject.Entities;

namespace ReCapProject.DAL.Concrete.EntityFramework
{
    public class BrandDAL:EFRepositoryBase<Brand,ReCapProjectContext>,IBrandDAL
    {
      
    }
}
