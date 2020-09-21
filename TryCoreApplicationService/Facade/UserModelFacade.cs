using System;
using System.Collections.Generic;
using System.Text;
using Try_Core_Application_Service.Contract;
using Try_Core_Contract.Service;
using Try_Core_Entities;

namespace Try_Core_Application_Service.Facade
{
    public class UserModelFacade : IUserModelFacade
    {
        private readonly IUserModelService userModelService;

        public UserModelFacade(IUserModelService userModelService)
        {
            this.userModelService = userModelService;
        }
        public int AddUser(UserModel userModel)
        {
            return userModelService.AddUser(userModel);
        }

        public int DeleteUser(int Id)
        {
            return userModelService.DeleteUser(Id);
        }

        public List<UserModel> GetAllUser()
        {
            return userModelService.GetAllUser();
        }

        public UserModel GetOneUser(int Id)
        {
            return userModelService.GetOneUser(Id);
        }
        public object GetCreateDate(int Id)
        {
            return userModelService.GetCreateDate(Id);
        }
        public UserModel UpdateUser(UserModel userModel)
        {
            return userModelService.Update(userModel);
        }
    }
}
