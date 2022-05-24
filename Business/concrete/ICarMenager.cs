using Business.Abstract;
using DataAccess.Abstract;
using Entities.concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.concrete
{
    public class ICarMenager : ICarService
    {
         ICarDal _CarDal;


        public ICarMenager(ICarDal CarDal)
        {
            _CarDal = CarDal;
        }
        public List<Car> GetAll()
        {
            return _CarDal.GetAll();
        }
    }
}
