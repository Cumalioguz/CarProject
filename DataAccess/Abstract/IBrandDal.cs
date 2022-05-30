using Core.DataAccess.EntityFramework;
using Entities.concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IBrandDal:IEntityRepository<Brand>
    {
    }
}
