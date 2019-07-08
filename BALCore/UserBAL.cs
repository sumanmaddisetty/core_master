using System;
using System.Collections.Generic;
using Core_DALInterface;
using Core_DomainModel;
using Core_BALInterfaceCore;
//using Core

namespace Core_BAL
{

    public class UserBAL: IUserBAL
    {

        private IUserDAL userDAL;
        public UserBAL(IUserDAL userDAL) {
            this.userDAL = userDAL;
            }
        public List<User> GetUsers()
        {
            return userDAL.GetUsers();
        }

    }
}
