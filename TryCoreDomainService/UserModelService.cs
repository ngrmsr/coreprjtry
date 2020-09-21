using System;
using System.Collections.Generic;
using System.Text;
using Try_Core_Contract.Service;
using Try_Core_Entities;
using Try_Infrastructure_Data_Base_Sql_Server_Data;

namespace Try_Core_Domain_Service
{
    public class UserModelService : IUserModelService
    {
        private readonly UnitOfWork unitOfWork;

        public UserModelService(UnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public int AddUser(UserModel userModel)
        {
            return unitOfWork.UserModelRepository.AddUser(userModel);
        }

        public int DeleteUser(int Id)
        {
            return unitOfWork.UserModelRepository.DeleteUser(Id);
        }

        public List<UserModel> GetAllUser()
        {
            return unitOfWork.UserModelRepository.GetAllUser();
        }

        public UserModel GetOneUser(int Id)
        {
            return unitOfWork.UserModelRepository.GetOneUser(Id);
        }
        public object GetCreateDate(int Id)
        {
            return unitOfWork.UserModelRepository.GetCreateDate(Id);
        }
        public UserModel Update(UserModel userModel)
        {
            return unitOfWork.UserModelRepository.UpdateUser(userModel);
        }
    }
}
