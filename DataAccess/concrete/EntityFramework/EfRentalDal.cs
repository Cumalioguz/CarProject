using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.concrete.EntityFramework
{
    public class EfRentalDal:EfEntityRepositoryBase<Rental,DataContext>,IRentalDal
    {
    }
}
