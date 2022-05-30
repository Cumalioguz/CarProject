using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.concrete.EntityFramework
{
    public class EfColorDal : EfEntityRepositoryBase<Color, DataContext>, IColorDal
    {
        

       
    }
}
