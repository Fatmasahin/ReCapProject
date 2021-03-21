using System;
using System.Collections.Generic;
using ReCapProject.Core.Utilities.Results;
using ReCapProject.Entities.Concrete;

namespace ReCapProject.BLL.Abstract
{
    public interface IBrandService
    {
        IDataResult<List<Brand>> GetAll();
    }
}


