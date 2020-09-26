using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Try_Core_Entities
{
    public class UserModel:INotifyPropertyChanged
    {
        public int UserModelId { get; set; }
        //public string UserName { get; set; }
        private string UserName;

        public string Username
        {
            get { return UserName; }
            set {
                if (UserName!=value)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Username"));
                }
                UserName = value; 
            }
        }

        private string PassWord;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Password
        {
            get { return PassWord; }
            set { PassWord = value+"9999"; }
        }


        public List<AccountModel> Accounts { get; set; }
    }
}
