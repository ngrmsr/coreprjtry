using System;
using System.Collections.Generic;
using System.Text;
using Try_Core_Entities;

namespace Try_Core_Application_Service.Contract
{
  public interface IAccountModelFacade
    {
        int AddAccount(AccountModel AccountModel);
        AccountModel UpdateAccount(AccountModel AccountModel);
        int DeleteAccount(int Id);
        List<AccountModel> GetAllAccount();
        AccountModel GetOneAccount(int Id);
        object GetCreateDate(int Id);
    }
}
