using Business.Abstract;
using DataAccess.concrete;
using Entities.concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.concrete
{
    public class CarMenager : ICarService
    {
         ICarDal _CarDal;


        public CarMenager(ICarDal CarDal)
        {
            _CarDal = CarDal;
        }

        public void Add(Car car)
        {
           
            _CarDal.Add(car);
        }
        public void Update(Car car)
        {
            _CarDal.Update(car);
        }
        public List<CarDetailDto> CarDetails()
        {
            return _CarDal.GetCarDetails();
        }
        public void Delete(Car car)
        {
           _CarDal.Delete(car);
        }
        public List<Car> GetAll()
        {
           
            return _CarDal.GetAll();
        }

        public Car GetById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
