using DataAccess.Abstract;
using Entities.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

/*namespace DataAccess.concrete
{
    public class CarDal : ICarDal
    {
        List<Car>_cars; 
        List<Color> _colors;
        public CarDal()
        {
            _cars = new List<Car>
            {
            new Car { Id = 1, BrandId = 2, ColorId = 1,  CarName = "bmw" },
            new Car { Id = 2, BrandId = 2, ColorId = 2,  CarName = "audi" },
            new Car { Id = 3, BrandId = 1, ColorId = 2,  CarName = "passat" },
            new Car { Id = 4, BrandId = 3, ColorId = 1,  CarName = "volvo" }
            };
            _colors = new List<Color>
            {
                new Color { ColorId = 1, ColorName ="beyaz"},
                new Color { ColorId = 2, ColorName ="siyah" },

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
           
            carToUpdate.CarName = car.CarName;

        }

        public void Sil(Car car)
        {
          Car carToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);
            
            _cars.Remove(carToDelete);
        }



       

        public void Add(Car entity)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars; ;
        }

        public void Update(Car entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Car entity)
        {
            throw new NotImplementedException();
        }
    }
}*/
