using Business.Concrete;
using DataAccess.Concrete;
using System;

namespace ConsoleUII
{
    public class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            Console.WriteLine("\n");
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(car.CarName + " " + car.BrandName + " " + car.Description + " " + car.ColorName + " " + car.ModelYear + " " + car.DailyPrice);


            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName + "/" + car.BrandName);
                }
            }
        }

    }
}
