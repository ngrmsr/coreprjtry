using System;
using System.Collections.Generic;
using System.Text;

namespace Try_Core_Entities.Model
{
   public class AccountLoanModel
    {
        public int AccountLoanModelId { get; set; }
        public AccountModel Accounts { get; set; }
        public LoanModel Loans { get; set; }
    }
}
