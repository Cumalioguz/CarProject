using System;
using System.Collections.Generic;
using System.Text;
using Entities.concrete;
//using Entities.concrete.Car;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        List<Car> GetAll();
        List<Car> GetById(int id);
        void Ekle(Car car);
        void Sil(Car car);
        void Guncelle(Car car);

    }
}
