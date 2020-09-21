using System;
using System.Collections.Generic;
using System.Text;
using Try_Core_Application_Service.Contract;
using Try_Core_Entities;

namespace Try_Core_End_Point_App
{
  public  class LoanManager
    {
        private readonly ILoanModelFacade loanModelFacade;

        public LoanManager(ILoanModelFacade loanModelFacade)
        {
            this.loanModelFacade = loanModelFacade;
        }
        public int AddLoan(LoanModel loanModel)
        {

            return loanModelFacade.AddLoan(loanModel);
        }
        public LoanModel UpdateLoan(LoanModel loanModel)
        {

            return loanModelFacade.UpdateLoan(loanModel);
        }
        public object GetCreateDate(int Id)
        {
            return loanModelFacade.GetCreateDate(Id);
        }
        public int DeleteLoan(int Id)
        {
            return loanModelFacade.DeleteLoan(Id);
        }
        public List<LoanModel> GettAll()
        {

            return loanModelFacade.GetAllLoan();
        }
    }
}
