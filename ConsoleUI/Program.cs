using Business.concrete;
using DataAccess.concrete;
using DataAccess.concrete.EntityFramework;
using Entities.concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //ColorTest();
            CarTest();

        }

        private static void CarTest()
        {
            CarMenager carMenager = new CarMenager(new EfCarDal());
            //carMenager.Add(new Car { CarName = "taksi",CarId=1,ColorId=1,BrandId=1 });
            //carMenager.Delete(new Car {  CarId = 6 });
            carMenager.Update(new Car { CarId = 1, CarName = "teyyare",ColorId=1,BrandId=2 });
            foreach (var c in carMenager.CarDetails())
            {
                Console.WriteLine(c.CarName+"-->"+c.ColorName+"-->"+c.BrandName);
            }
           
        }

        private static void ColorTest()
        {
            ColorMenager colorMenager = new ColorMenager(new EfColorDal());
            foreach (var c in colorMenager.GetAll())
            {
                Console.WriteLine(c.ColorName);
            }
        }
    }
}
