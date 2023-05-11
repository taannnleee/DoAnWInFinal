using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnWinDows.BusinessLayer.Models
{
    public class EmployeeAccount
    {
        private string loginid;
        private string username;
        private string password;
        private string employeeid;
        private string accounttype;
        private string accountstatus;
        private DateTime createdtime;
        private DateTime lastlogintime;

        public string Loginid { get => loginid; set => loginid = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Employeeid { get => employeeid; set => employeeid = value; }
        public string Accounttype { get => accounttype; set => accounttype = value; }
        public string Accountstatus { get => accountstatus; set => accountstatus = value; }
        public DateTime Createdtime { get => createdtime; set => createdtime = value; }
        public DateTime Lastlogintime { get => lastlogintime; set => lastlogintime = value; }

        public EmployeeAccount() { }

        public EmployeeAccount(string loginid, string username, string password, string employeeid, string accounttype, string accountstatus, DateTime createdtime, DateTime lastlogintime)
        {
            Loginid = loginid;
            Username = username;
            Password = password;
            Employeeid = employeeid;
            Accounttype = accounttype;
            Accountstatus = accountstatus;
            Createdtime = createdtime;
            Lastlogintime = lastlogintime;
        }

        public EmployeeAccount(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
