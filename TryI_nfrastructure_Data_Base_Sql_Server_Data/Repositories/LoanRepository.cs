using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Try_Core_Contract.Repositories;
using Try_Core_Entities;
using Try_Infrastructure_Data_Base_Sql_Server_PersistanceEF;

namespace Try_Infrastructure_Data_Base_Sql_Server_Data.Repositories
{
    public class LoanRepository : ILoanRepository
    {
        private readonly MyContext ctx;

        public LoanRepository(MyContext ctx)
        {
            this.ctx = ctx;
        }
        public int AddLoan(LoanModel loanModel)
        {
            ctx.LoanModel.Add(loanModel);
            ctx.SaveChanges();
            return loanModel.LoanModelId;
        }

        public int DeleteLoan(int Id)
        {
            var loan = GetOneLoan(Id);
            ctx.LoanModel.Remove(loan);
            ctx.SaveChanges();
            return 0;
        }

        public List<LoanModel> GetAllLoan()
        {
            return ctx.LoanModel.ToList();
        }

        public LoanModel GetOneLoan(int Id)
        {
            var loan = ctx.LoanModel.Find(Id);
            return loan;
        }
        public object GetCreateDate(int Id)
        {
            var loan = GetOneLoan(Id);
            var dateTime = ctx.Entry(loan).Property("createDate").CurrentValue;
            return dateTime;
        }

        public LoanModel UpdateLoan(LoanModel loanModel)
        {
            var loan = GetOneLoan(loanModel.LoanModelId);
            loan.Amount = loanModel.Amount;
            ctx.SaveChanges();
            return loanModel;
        }
    }
}
