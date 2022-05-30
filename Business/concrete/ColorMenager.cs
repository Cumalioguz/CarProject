using Business.Abstract;
using DataAccess.Abstract;
using Entities.concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.concrete
{
    public class ColorMenager : IColorService
    {
        IColorDal _colorDal;
        public ColorMenager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }
    }
}
