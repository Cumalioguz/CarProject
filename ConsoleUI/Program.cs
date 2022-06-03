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
            //UserTest();
            //RentalTest();
        }

        //private static void RentalTest()
        //{
            /*RentalMenager rentalMenager = new RentalMenager(new EfRentalDal());
            CarMenager carMenager = new CarMenager(new EfCarDal());
            rentalMenager.Add(new Rental
            {
               // CarId = 8,
                CustomerId = 9,
                UserId = 4,
                RentDate = new DateTime(2022, 06, 01, 15, 54, 00),
                ReturnDate = new DateTime(2022, 06, 01, 08, 54, 00)
            });
            var result = carMenager.GetAll();
            foreach (var c in result.Data)
            {
                foreach (var r in rentalMenager.GetAll())
                {
                    if (r.ReturnDate != null)
                    {
                        rentalMenager.GetAll();
                    }

                }
            }
        }*/

        private static void UserTest()
        {
            UserMenager userMenager = new UserMenager(new EfUserDal());

            /* userMenager.Add(new User
             {
                 FirstName = "Cumali",
                 LastName = "Oğuz",
                 Email = "assdasd@abca.com", Password = "cscvefvev", UserId = 1 });*/
            userMenager.Add(new User
            {
                FirstName = "caner",
                LastName = "Oğuz",
                Email = "assdasd@abca.com",
                Password = "cscvefvev",
                UserId = 2
            });
            userMenager.Add(new User
            {
                FirstName = "taner",
                LastName = "Oğuz",
                Email = "assdasd@abca.com",
                Password = "cscvefvev",
                UserId = 3
            });
            foreach (var u in userMenager.GetAll())
            {
                Console.WriteLine(u.FirstName);
            }
        }

        private static void CarTest()

        {
            CarMenager carMenager = new CarMenager(new EfCarDal());
            
            //carMenager.Add(new Car { CarName = "taksi",CarId=1,ColorId=1,BrandId=1 });
            //carMenager.Delete(new Car {  CarId = 6 });
           // carMenager.Update(new Car { CarId = 1, CarName = "teyyare",ColorId=1,BrandId=2 });
            var result = carMenager.GetAll();
            if (result.Success)
            {
                foreach (var c in result.Data)
                {
                    Console.WriteLine(c.CarName);
                }
               
            }
            else
            {
                Console.WriteLine(result.Message);
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
