using DataAccess.Abstract;
using Entities.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.concrete
{
    public class CarDal : ICarDal
    {
        List<Car>_cars; 
        public CarDal()
        {
            _cars = new List<Car>
            {
            new Car { Id = 1, BrandId = 2, ColorId = 1, ModelYear = 2002, DailyPrice = 6, Description = "hızlı" },
            new Car { Id = 2, BrandId = 2, ColorId = 2, ModelYear = 2009, DailyPrice = 5, Description = "hızlı" },
            new Car { Id = 3, BrandId = 1, ColorId = 2, ModelYear = 2022, DailyPrice = 1, Description = "hızlı" },
            new Car { Id = 4, BrandId = 3, ColorId = 1, ModelYear = 2000, DailyPrice = 4, Description = "hızlı" }
            };
        }
        public void Ekle(Car car)
        {
            _cars.Add(car);
        }

        List<Car>GetAll()
        {
           return _cars;
        }

        public List<Car> GetById(int id)
        {
          return _cars.Where(c => c.Id == id).ToList();
        }

        public void Guncelle(Car car)
        {
           Car carToUpdate=_cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;

        }

        public void Sil(Car car)
        {
          Car carToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);
          _cars.Remove(carToDelete);
        }

        List<Car> ICarDal.GetAll()
        {
            return _cars;
        }
    }
}
