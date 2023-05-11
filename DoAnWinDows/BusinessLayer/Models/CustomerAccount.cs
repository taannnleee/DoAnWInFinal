using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DoAnWinDows.BusinessLayer.Models
{
    public class CustomerAccount
    {
        private string loginid;
        private string username;
        private string password;
        private int accountnumber;
        private string customerid;
        private string accounttype;
        private string balance;
        private string accountstatus;
        private DateTime createdtime;
        private DateTime lastlogintime;

        public int Accountnumber { get => accountnumber; set => accountnumber = value; }
        public string Customerid { get => customerid; set => customerid = value; }
        public string Accounttype { get => accounttype; set => accounttype = value; }
        public string Balance { get => balance; set => balance = value; }
        public string Accountstatus { get => accountstatus; set => accountstatus = value; }
        public DateTime Createdtime { get => createdtime; set => createdtime = value; }
        public DateTime Lastlogintime { get => lastlogintime; set => lastlogintime = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Loginid { get => loginid; set => loginid = value; }

        public CustomerAccount() { }
        public CustomerAccount(int accountnumber)
        {
            Accountnumber = accountnumber;
        }

        public CustomerAccount(string loginid, string username, string password, int accountnumber, string customerid, string accounttype, string balance, string accountstatus, DateTime createdtime, DateTime lastlogintime)
        {
            Loginid = loginid;
            Username = username;
            Password = password;
            Accountnumber = accountnumber;
            Customerid = customerid;
            Accounttype = accounttype;
            Balance = balance;
            Accountstatus = accountstatus;
            Createdtime = createdtime;
            Lastlogintime = lastlogintime;
        }

        public CustomerAccount(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
