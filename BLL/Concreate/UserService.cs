using BLL.Abstract;
using Entity.Entities;
using Entity.Repositories.Abstract.IUserService;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Concreate
{
    public class UserService : IUserService
    {
        IUserDal _userDal;

        public UserService(IUserDal userDal)
        {
            _userDal = userDal;

        }
        public List<User> GetAll()
        {
            return _userDal.GetAll();
        }
    }
}
