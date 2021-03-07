using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReCapProject.BLL.Abstract;
using ReCapProject.BLL.Concrete;
using ReCapProject.Core.Utilities.Results;
using ReCapProject.DAL.Concrete.EntityFramework;
using ReCapProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReCapProject.WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CarsController : ControllerBase
	{
		ICarService _carService;

		public CarsController(ICarService carService)
		{
			_carService = carService;
		}

		[HttpGet]
		public IDataResult<List<Car>> GetAll()
		{
			return _carService.GetAllCars();

		}
	}
}
