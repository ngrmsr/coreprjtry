using System;
using System.Collections.Generic;
using System.Text;

namespace Try_Core_Entities
{
   public class AccountModel
    {
        public int AccountModelId { get; set; }
        public int Amount { get; set; }
        public UserModel user { get; set; }
        
    }
}
