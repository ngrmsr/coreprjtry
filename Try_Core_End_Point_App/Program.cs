using Microsoft.EntityFrameworkCore;
using Ninject;
using System;
using Try_Core_Application_Service;
using Try_Core_Application_Service.Contract;
using Try_Core_Application_Service.Facad;
using Try_Core_Application_Service.Facade;
using Try_Core_Comtract.Service;
using Try_Core_Contract.Service;
using Try_Core_Domain_Service;
using Try_Core_Entities;
using Try_Core_Entities.Model;
using Try_Infrastructure_Data_Base_Sql_Server_PersistanceEF;

namespace Try_Core_End_Point_App
{
    class Program
    {
        static void Main(string[] args)
        {
            DbContextOptionsBuilder<MyContext> options = new DbContextOptionsBuilder<MyContext>();
            options.UseSqlServer("Password=22552111;Persist Security Info=True;User ID=sa;Initial Catalog=EFTestBank;Data Source=.");
            MyContext ctx = new MyContext(options.Options);
            ctx.Database.EnsureCreated();
            //MyContext ctx = new MyContext();
            //UserModel user = new UserModel()
            //{
            //    UserName = "aa"
            //};
            //AccountModel Account = new AccountModel()
            //{
            //    Amount = 2000,
            //    user = user
            //};
            //LoanModel Loan = new LoanModel()
            //{
            //    Amount = 5000,
            //    Type = "home",

            //};
            //ctx.use.Add(user);
            //ctx.Add(Account);
            //AccountManager account = new AccountManager();
            //account.AddAccount(5000,);
            IKernel ninjectKernel = new StandardKernel();
            ninjectKernel.Bind<IUserModelService>().To<UserModelService>();
            ninjectKernel.Bind<IUserModelFacade>().To<UserModelFacade>();
            UserManager userModel = new UserManager(ninjectKernel.Get<IUserModelFacade>());
            userModel.AddUser(new UserModel { UserName = "aaaa" });
            UserModel user = userModel.GetOneUser(1);
            ninjectKernel.Bind<IAccountModelService>().To<AccountModelService>();
            ninjectKernel.Bind<IAccountModelFacade>().To<AccountModelFacade>();
            AccountManager account = new AccountManager(ninjectKernel.Get<IAccountModelFacade>());
            account.AddAccount(new AccountModel
            {
                user = user
            ,
                Amount = 5000
            ,
                address = new AddressModel() { City = "teharn", Street = "ghale" }
            }
            );
            AccountModel accountModel = account.GetOneAccount(1);
            ninjectKernel.Bind<ILoanModelService>().To<LoanModelService>();
            ninjectKernel.Bind<ILoanModelFacade>().To<LoanModelFacade>();
            LoanManager loanManager = new LoanManager(ninjectKernel.Get<ILoanModelFacade>());
            loanManager.AddLoan(new LoanModel
            {
                Amount = 2000,
                Type = "Home",
                loanDetail = new LoanDetailModel()
                {
                    LoanIdentifierName = "hassan"
                ,
                    NumberOfInstallments = 20
                    ,
                    AmountPerInstallment = 100
                }
            }
            );
            Console.ReadKey();
        }
    }
}
