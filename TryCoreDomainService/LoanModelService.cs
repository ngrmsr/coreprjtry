using System;
using System.Collections.Generic;
using System.Text;
using Try_Core_Contract.Service;
using Try_Core_Entities;
using Try_Infrastructure_Data_Base_Sql_Server_Data;

namespace Try_Core_Domain_Service
{
    public class LoanModelService : ILoanModelService
    {
        private readonly UnitOfWork unitOfWork;

        public LoanModelService(UnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public int AddLoan(LoanModel loanModel)
        {
           return unitOfWork.LoanModelRepository.AddLoan(loanModel);
        }

        public int DeleteLoan(int Id)
        {
            return unitOfWork.LoanModelRepository.DeleteLoan(Id);
        }

        public List<LoanModel> GetAllLoan()
        {
            return unitOfWork.LoanModelRepository.GetAllLoan();
        }

        public LoanModel GetOneLoan(int Id)
        {
            return unitOfWork.LoanModelRepository.GetOneLoan(Id);
        }

        public LoanModel Update(LoanModel loanModel)
        {
            return unitOfWork.LoanModelRepository.UpdateLoan(loanModel);
        }
        public object GetCreateDate(int Id)
        {
            return unitOfWork.LoanModelRepository.GetCreateDate(Id);
        }
    }
}
