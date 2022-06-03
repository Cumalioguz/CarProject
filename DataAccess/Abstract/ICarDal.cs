
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace DataAccess.concrete
{
    public interface ICarDal : IEntityRepository<Car>
    {
        List<CarDetailDto> GetCarDetails();
    }
}