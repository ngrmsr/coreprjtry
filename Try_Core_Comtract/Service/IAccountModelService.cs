using System;
using System.Collections.Generic;
using System.Text;
using Try_Core_Entities;

namespace Try_Core_Comtract.Service
{
  public  interface IAccountModelService
    {
        int AddAccount(AccountModel account);
        AccountModel Update(AccountModel account);
        int DeleteAccount(int Id);
        List<AccountModel> GetAllAccount();
        AccountModel GetOneAccount(int Id);
        object GetCreateDate(int Id);
    }
}
