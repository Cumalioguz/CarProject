using Business.Abstract;
using DataAccess.Abstract;
using Entities.concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.concrete
{
    public class UserMenager : IUserService
    {
        IUserDal _userDal;
        public UserMenager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public List<User> GetAll()
        {
          return _userDal.GetAll();
        }
    }
}
