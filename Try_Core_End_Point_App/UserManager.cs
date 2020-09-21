using System;
using System.Collections.Generic;
using System.Text;
using Try_Core_Application_Service.Contract;
using Try_Core_Entities;

namespace Try_Core_End_Point_App
{
   public class UserManager
    {
        private readonly IUserModelFacade userModelFacade;

        public UserManager(IUserModelFacade userModelFacade)
        {
            this.userModelFacade = userModelFacade;
        }
        public int AddUser(UserModel userModel)
        {
            
            return userModelFacade.AddUser(userModel);
        }
        public UserModel GetOneUser(int Id)
        {
            return userModelFacade.GetOneUser(Id);
        }
        public int DeleteUser(int Id)
        {
            return userModelFacade.DeleteUser(Id);
        }
        public object GetCreateDate(int Id)
        {
            return userModelFacade.GetCreateDate(Id);
        }
        public UserModel UpdateUser(UserModel userModel)
        {

            return userModelFacade.UpdateUser(userModel);
        }
        public List<UserModel> GettAll()
        {

            return userModelFacade.GetAllUser();
        }

    }
}
