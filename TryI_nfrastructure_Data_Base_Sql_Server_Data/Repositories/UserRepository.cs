using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Try_Core_Contract.Repositories;
using Try_Core_Entities;
using Try_Infrastructure_Data_Base_Sql_Server_PersistanceEF;

namespace Try_Infrastructure_Data_Base_Sql_Server_Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly MyContext ctx;

        public UserRepository(MyContext ctx)
        {
            this.ctx = ctx;
        }
        public int AddUser(UserModel userModel)
        {
            ctx.UserModel.Add(userModel);
            ctx.SaveChanges();
            return userModel.UserModelId;
        }

        public int DeleteUser(int Id)
        {
            var user = GetOneUser(Id);
            ctx.UserModel.Remove(user);
            ctx.SaveChanges();
            return 0;
        }

        public List<UserModel> GetAllUser()
        {
            return ctx.UserModel.ToList();
        }

        public UserModel GetOneUser(int Id)
        {
            var user = ctx.UserModel.Find(Id);
            return user;
        }
        public object GetCreateDate(int Id)
        {
            var user = GetOneUser(Id);
            //var user1 = GetAllUser();
            var dateTime = ctx.Entry(user).Property("createDate").CurrentValue;
            //var dateTime1 = ctx.Entry(user1).Property("createDate");
            return dateTime;
        }
        public UserModel UpdateUser(UserModel userModel)
        {
            var user = GetOneUser(userModel.UserModelId);
            user.UserName = userModel.UserName;
            ctx.SaveChanges();
            return userModel;
        }
    }
}
