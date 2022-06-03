using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Untilities.Result;
using DataAccess.concrete;
using Entities.concrete;
using Entities.DTOs;
using System;
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
        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {
           if (car.CarName.Length<2)
            {
                return new ErrorResult(Messages.CarNameInvalied);
            }
            _CarDal.Add(car);
            return new SuccessResult(Messages.CarAdded);
            
        }
        public IResult Update(Car car)
        {
            if (car.CarName.Length < 2)
            {
                return new ErrorResult(Messages.CarNameInvalied);
            }
            _CarDal.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }
        public IDataResult<List<CarDetailDto>> CarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_CarDal.GetCarDetails(),Messages.CarListed);
        }
        public IResult Delete(Car car)
        {
            if (car.CarName.Length < 2)
            {
                return new ErrorResult(Messages.CarNameInvalied);
            }
            _CarDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }
        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour==22)
            {
                return new ErrorDataResult<List<Car>>(_CarDal.GetAll(),Messages.MaintenaceTime);
            }
            return new SuccessDataResult<List<Car>>(_CarDal.GetAll(),Messages.CarListed);
        }

        public IDataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car>(_CarDal.Get(c => c.CarId == id), Messages.CarListed);
        }
    }
}
