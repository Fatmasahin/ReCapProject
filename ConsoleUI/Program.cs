using ReCapProject.BLL.Concrete;
using ReCapProject.DAL.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
	class Program
	{
		static void Main(string[] args)
		{
			CarManager carManager = new CarManager(new CarDAL(),new BrandManager(new BrandDAL()));
			
			foreach (var carDetail in carManager.GetCarDetails().Data)
			{ 
				
				Console.WriteLine($"Marka:{carDetail.BrandName.Trim()},İsim : {carDetail.CarName}, Renk: {carDetail.ColorName}, Fiyat: {Decimal.Round(carDetail.DailyPrice,2)} TL");

			}
			
		}
	}
}
