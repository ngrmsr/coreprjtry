using System;
using System.Collections.Generic;
using System.Text;
using Try_Core_Application_Service.Contract;
using Try_Core_Contract.Service;
using Try_Core_Entities;

namespace Try_Core_Application_Service.Facade
{
    public class LoanModelFacade : ILoanModelFacade
    {
        private readonly ILoanModelService loanModelService;

        public LoanModelFacade(ILoanModelService loanModelService)
        {
            this.loanModelService = loanModelService;
        }
        public int AddLoan(LoanModel LoanModel)
        {
           return loanModelService.AddLoan(LoanModel);
        }

        public int DeleteLoan(int Id)
        {
            return loanModelService.DeleteLoan(Id);
        }

        public List<LoanModel> GetAllLoan()
        {
            return loanModelService.GetAllLoan();
        }

        public LoanModel GetOneLoan(int Id)
        {
            return loanModelService.GetOneLoan(Id);
        }
        public object GetCreateDate(int Id)
        {
            return loanModelService.GetCreateDate(Id);
        }
        public LoanModel UpdateLoan(LoanModel LoanModel)
        {
            return loanModelService.Update(LoanModel);
        }
    }
}
