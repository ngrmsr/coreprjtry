using System;
using System.Collections.Generic;
using System.Text;
using Try_Core_Application_Service.Contract;
using Try_Core_Comtract.Service;
using Try_Core_Entities;

namespace Try_Core_Application_Service.Facad
{
   public class AccountModelFacade:IAccountModelFacade
    {
        
        private readonly IAccountModelService accountModelService;

        public AccountModelFacade(IAccountModelService AccountModelService)
        {     
            accountModelService = AccountModelService;
        }


        public int AddAccount(AccountModel AccountModel )
        {

            return accountModelService.AddAccount(AccountModel);
        }
        public AccountModel UpdateAccount(AccountModel AccountModel)
        {
            return accountModelService.Update(AccountModel);
        }
        public int DeleteAccount(int Id)
        {
            return accountModelService.DeleteAccount(Id);
        }
        public List<AccountModel> GetAllAccount()
        {
            return accountModelService.GetAllAccount();
        }

        public AccountModel GetOneAccount(int Id)
        {
            return accountModelService.GetOneAccount(Id);
        }
        public object GetCreateDate(int Id)
        {
            return accountModelService.GetCreateDate(Id);
        }
    }
}
