using System;
using System.Collections.Generic;
using System.Text;
using Try_Core_Application_Service.Contract;
using Try_Core_Entities;

namespace Try_Core_End_Point_App
{
   public class AccountManager
    {
        private readonly IAccountModelFacade accountModelFacade;

        public AccountManager(IAccountModelFacade accountModelFacade)
        {
            this.accountModelFacade = accountModelFacade;
        }
        public int AddAccount(/*int Amunt,UserModel user*/ AccountModel accountModel)
        {
            //AccountModel accountModel = new AccountModel()
            //{
            //    Amount = 55,
            //    user = user
            //};
            //accountModelFacade.AddAccount(accountModel);
            return accountModelFacade.AddAccount(accountModel);
        }
        public AccountModel GetOneAccount(int Id)
        {
            return accountModelFacade.GetOneAccount(Id);
        }
        public int DeleteAccount(int Id)
        {
            return accountModelFacade.DeleteAccount(Id);
        }
        public AccountModel UpdateAccount(AccountModel accountModel)
        {
            return accountModelFacade.UpdateAccount(accountModel);
        }
        public object GetCreateDate(int Id)
        {
            return accountModelFacade.GetCreateDate(Id);
        }
        public List<AccountModel> GettAll()
        {

            return accountModelFacade.GetAllAccount();
        }
    }
}
