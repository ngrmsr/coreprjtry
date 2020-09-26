using System;
using System.Collections.Generic;
using System.Text;

namespace Try_Core_Entities
{
    public class UserModel
    {
        public int UserModelId { get; set; }
        public string UserName { get; set; }

        private string PassWord;
        public string Password
        {
            get { return PassWord; }
            set { PassWord = value+"9999"; }
        }


        public List<AccountModel> Accounts { get; set; }
    }
}
