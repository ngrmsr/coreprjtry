using System;
using System.Collections.Generic;
using System.Text;

namespace Try_Core_Entities
{
    public class UserModel
    {
        public int UserModelId { get; set; }
        public string UserName { get; set; }

        //private string PassWord;
        //public string PassWord
        //{
        //    get { return PassWord; }
        //    set { PassWord = value; }
        //}


        public List<AccountModel> Accounts { get; set; }
    }
}
