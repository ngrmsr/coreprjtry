using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Try_Core_Entities.Model;

namespace Try_Core_Entities
{
    [ConcurrencyCheck]
   public class LoanModel
    {
        public int LoanModelId { get; set; }
        public int Amount { get; set; }
        public string Type { get; set; }
        public int? LoanDetailModelId { get; set; }
        public LoanDetailModel loanDetail { get; set; }
    }
}
