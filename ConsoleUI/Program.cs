using ReCapProject.BLL.Concrete;
using ReCapProject.DAL.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
	class Program
	{
		static void Main(string[] args)
		{
			CarManager carManager = new CarManager(new CarDAL());
			carManager.GetAllCars();
			Console.WriteLine("Çalıştı");
		}
	}
}
