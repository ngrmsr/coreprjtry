using System;
using System.Collections.Generic;
using System.Text;

namespace Try_Core_Entities.Model
{
   public class LoanDetailModel
    {
        public int LoanDetailModelId { get; set; }
        public string LoanIdentifierName { get; set; }
        public int NumberOfInstallments { get; set; }
        public decimal AmountPerInstallment { get; set; }
        public DateTime InstallmentStartDate { get; set; }
    }
}
