using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Abstract
{
    public interface IUserService
    {
        List<User> GetAll();
    }
}
