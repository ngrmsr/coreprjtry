using System;
using System.Collections.Generic;
using System.Text;
using Try_Core_Entities;

namespace Try_Core_Contract.Repositories
{
  public  interface ILoanRepository
    {
        int AddLoan(LoanModel loanModel);
        LoanModel UpdateLoan(LoanModel loanModel);
        int DeleteLoan(int Id);
        List<LoanModel> GetAllLoan();
        LoanModel GetOneLoan(int Id);
        object GetCreateDate(int Id);
    }
}
