using Business.Abstract;
using DataAccess.Abstract;
using Entities.concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.concrete
{
    public class RentalMenager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalMenager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;   
        }
        public void Add(Rental rental)
        {
            _rentalDal.Add(rental);
        }

        public List<Rental> GetAll()
        {
            return _rentalDal.GetAll();
        }
    }
}
