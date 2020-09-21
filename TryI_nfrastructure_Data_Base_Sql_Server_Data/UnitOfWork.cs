using System;
using System.Collections.Generic;
using System.Text;
using Try_Core_Contract;
using Try_Core_Contract.Repositories;
using Try_Infrastructure_Data_Base_Sql_Server_Data.Repositories;
using Try_Infrastructure_Data_Base_Sql_Server_PersistanceEF;

namespace Try_Infrastructure_Data_Base_Sql_Server_Data
{
   public class UnitOfWork
    {
        private readonly MyContext ctx;
        AccountRepsitory AccountRepsitory;
        LoanRepository LoanRepsitory;
        UserRepository UserRepsitory;
        public UnitOfWork(MyContext ctx)
        {
            this.ctx = ctx;
        }
        public AccountRepsitory AccountModelRepository { get => AccountRepsitory; }
        public LoanRepository LoanModelRepository { get => LoanRepsitory; }
        public UserRepository UserModelRepository { get => UserRepsitory; }


    }
}
