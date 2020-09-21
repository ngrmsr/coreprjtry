using System;
using System.Collections.Generic;
using System.Text;
using Try_Core_Entities;

namespace Try_Core_Contract.Service
{
  public  interface ILoanModelService
    {
        int AddLoan(LoanModel loanModel);
        LoanModel Update(LoanModel loanModel);
        int DeleteLoan(int Id);
        List<LoanModel> GetAllLoan();
        LoanModel GetOneLoan(int Id);
        object GetCreateDate(int Id);
    }
}
