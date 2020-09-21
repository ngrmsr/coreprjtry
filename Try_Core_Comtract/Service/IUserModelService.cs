using System;
using System.Collections.Generic;
using System.Text;
using Try_Core_Entities;

namespace Try_Core_Contract.Service
{
    public interface IUserModelService
    {
        int AddUser(UserModel userModel);
        UserModel Update(UserModel userModel);
        int DeleteUser(int Id);
        List<UserModel> GetAllUser();
        UserModel GetOneUser(int Id);
        object GetCreateDate(int Id);
    }
}
