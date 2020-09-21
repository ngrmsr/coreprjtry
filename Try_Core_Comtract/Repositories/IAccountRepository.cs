using System;
using System.Collections.Generic;
using System.Text;
using Try_Core_Entities;

namespace Try_Core_Contract.Repositories
{
   public interface IAccountRepository
    {
        int AddAccount(AccountModel accountModel);
        AccountModel UpdateAccount(AccountModel accountModel);
        int DeleteAccount(int Id);
        List<AccountModel> GetAllAccount();
        AccountModel GetOneAccount(int Id);
        object GetCreateDate(int Id);
    }
}
