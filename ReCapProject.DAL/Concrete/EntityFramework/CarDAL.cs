using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using ReCapProject.Core.DAL.EntityFramework;
using ReCapProject.DAL.Abstract;
using ReCapProject.Entities;
using ReCapProject.Entities.Concrete;
using ReCapProject.Entities.DTOs;
using System.Linq;

namespace ReCapProject.DAL.Concrete.EntityFramework
{
	public class CarDAL : EFRepositoryBase<Car, ReCapProjectContext>, ICarDAL
	{
		public List<CarDetailDTO> GetCarDetails()
		{
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.ID
                             join clr in context.Colors
                             on c.ColorId equals clr.ID
                             select new CarDetailDTO
                             {
                                 CarName=c.Name,
                                 BrandName=b.BrandName,
                                 ColorName=clr.ColorName,
                                 DailyPrice=c.DailyPrice
                             };
                return result.ToList();
            }
        }
	}
}
