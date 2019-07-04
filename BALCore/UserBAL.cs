using System;
using System.Collections.Generic;
using Core_DAL;
using Core_DomainModel;

namespace Core_BAL
{
    
    public class UserBAL
    {
      
        UserDAL userDAL = new UserDAL();
        public List<User> GetUsers()
        {
            return userDAL.GetUsers();
        }

    }
}
