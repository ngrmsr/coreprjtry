using System;
using System.Collections.Generic;
using System.Text;
using Try_Core_Entities;

namespace Try_Core_Contract.Repositories
{
  public  interface IUserRepository
    {
        int AddUser(UserModel userModel);
        UserModel UpdateUser(UserModel userModel);
        int DeleteUser(int Id);
        List<UserModel> GetAllUser();
        UserModel GetOneUser(int Id);
        object GetCreateDate(int Id);
    }
}
