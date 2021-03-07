using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReCapProject.BLL.Abstract;
using ReCapProject.BLL.Concrete;
using ReCapProject.Core.Utilities.Results;
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

		[HttpGet("getall")]
		public IActionResult GetAll()
		{
			var result=_carService.GetAllCars();
            if (result.Success)
            {
				return Ok(result);
            }
			return BadRequest();

		}
		[HttpGet("getbyid")]
		public IActionResult GetById(int id)
        {
			var result = _carService.GetCarById(id);
            if (result.Success)
            {
				return Ok(result);
            }
			return BadRequest();
        }

		[HttpPost("add")]
		public IActionResult Add(Car car)
        {
			var result = _carService.Add(car);
            if (result.Success)
            {
				return Ok();
            }
			return BadRequest();
        }
	}
}
