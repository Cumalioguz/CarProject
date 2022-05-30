using Core.DataAccess.EntityFramework;
using Entities.concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, DataContext>, ICarDal
    {
        public List<CarDetailDto>GetCarDetails()
        {
            using (DataContext context = new DataContext())
            {
                var result = from c in context.Car
                             join r in context.Color on c.ColorId equals r.ColorId
                             join b in context.Brand on c.BrandId equals b.BrandId
                             select new CarDetailDto
                             {
                                 CarName = c.CarName,
                                 ColorName = r.ColorName,
                                 BrandName = b.BrandName

                             };
                return result.ToList();
            }
        }
        
    }
}
