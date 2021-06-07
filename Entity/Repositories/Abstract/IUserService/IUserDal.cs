using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Repositories.Abstract.IUserService
{
    public interface IUserDal
    {
        List<User> GetAll();
    }
}
