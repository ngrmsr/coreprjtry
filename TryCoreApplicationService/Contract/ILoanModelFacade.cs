using System;
using System.Collections.Generic;
using System.Text;
using Try_Core_Entities;

namespace Try_Core_Application_Service.Contract
{
  public  interface ILoanModelFacade
    {
        int AddLoan(LoanModel LoanModel);
        LoanModel UpdateLoan(LoanModel LoanModel);
        int DeleteLoan(int Id);
        List<LoanModel> GetAllLoan();
        LoanModel GetOneLoan(int Id);
        object GetCreateDate(int Id);
    }
}
