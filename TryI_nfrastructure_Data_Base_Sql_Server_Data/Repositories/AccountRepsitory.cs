using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Try_Core_Contract.Repositories;
using Try_Core_Entities;
using Try_Infrastructure_Data_Base_Sql_Server_PersistanceEF;

namespace Try_Infrastructure_Data_Base_Sql_Server_Data
{
 public class AccountRepsitory : IAccountRepository
    {
        private readonly MyContext ctx;

        public AccountRepsitory(MyContext ctx)
        {
            this.ctx = ctx;
        }
        public int AddAccount(AccountModel accountModel)
        {
            ctx.AccountModel.Add(accountModel);
            ctx.SaveChanges();
            return accountModel.AccountModelId;
        }

        public int DeleteAccount(int Id)
        {
           var account= GetOneAccount(Id);
            ctx.AccountModel.Remove(account);
            ctx.SaveChanges();
            return 0;
        }

        public List<AccountModel> GetAllAccount()
        {
            var res = ctx.AccountModel.Include(a => a.user);
            return ctx.AccountModel.ToList();
        }

        public AccountModel GetOneAccount(int Id)
        {
            
            var account = ctx.AccountModel.Find(Id);
            //var res = ctx.Entry(account).Collection(c=>c.user)
            return account;
        }
        public object GetCreateDate(int Id)
        {
            var account = GetOneAccount(Id);
            var dateTime = ctx.Entry(account).Property("createDate").CurrentValue;
            return dateTime;
        }

        public AccountModel UpdateAccount(AccountModel accountModel)
        {
            var account = GetOneAccount(accountModel.AccountModelId);
            account.Amount = accountModel.Amount;
            ctx.SaveChanges();
            return accountModel;
        }
    }
}
