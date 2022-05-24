using Business.Abstract;
using Business.concrete;
using DataAccess.Abstract;
using DataAccess.concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarMenager carMenager = new ICarMenager(new CarDal());

            foreach (var car in carMenager.GetAll())
            {
                Console.WriteLine(car.ModelYear);
            }

            
        }
    }
}
