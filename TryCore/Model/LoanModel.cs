using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Try_Core_Entities.Model;

namespace Try_Core_Entities
{
  
   public class LoanModel
    {
        public int LoanModelId { get; set; }
        //[ConcurrencyCheck]
        public int Amount { get; set; }
        public string Type { get; set; }
        //[Timestamp]
        public byte[] Token { get; set; }
        public int? LoanDetailModelId { get; set; }
        public LoanDetailModel loanDetail { get; set; }
    }
}
