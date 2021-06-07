using Entity.Entities;
using Entity.Entities.Context;
using Entity.Repositories.Abstract.IUserService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity.Repositories.Concreate.UserService
{
    public class UserDal : IUserDal
    {
        public List<User> GetAll()
        {
            using (BaseContextDB db=new BaseContextDB())
            {
                return db.Users.ToList();
            }
        }
    }
}
