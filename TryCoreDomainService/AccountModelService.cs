using System;
using System.Collections.Generic;
using System.Text;
using Try_Core_Comtract.Service;
//using Try_Core_Contract.Service;
using Try_Core_Entities;
using Try_Infrastructure_Data_Base_Sql_Server_Data;

namespace Try_Core_Application_Service
{
    public class AccountModelService : IAccountModelService
    {
        private readonly UnitOfWork commenUnitOfWork;

        public AccountModelService(UnitOfWork commenUnitOfWork)
        {
            this.commenUnitOfWork = commenUnitOfWork;
        }
        public int AddAccount(AccountModel account)
        {
            return commenUnitOfWork.AccountModelRepository.AddAccount(account);
        }

        public int DeleteAccount(int Id)
        {
            return commenUnitOfWork.AccountModelRepository.DeleteAccount(Id);
        }

        public AccountModel Update(AccountModel account)
        {
            return commenUnitOfWork.AccountModelRepository.UpdateAccount(account);
        }
        public List<AccountModel> GetAllAccount()
        {
            return commenUnitOfWork.AccountModelRepository.GetAllAccount();
        }

        public AccountModel GetOneAccount(int Id)
        {
            return commenUnitOfWork.AccountModelRepository.GetOneAccount(Id);
        }
        public object GetCreateDate(int Id)
        {
            return commenUnitOfWork.AccountModelRepository.GetCreateDate(Id);
        }
    }
}
