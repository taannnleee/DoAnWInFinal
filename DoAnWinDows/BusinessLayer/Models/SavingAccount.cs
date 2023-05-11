using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnWinDows.BusinessLayer.Models
{
    public class SavingAccount
    {
        private int savingaccountid;
        private string customerid;
        private string balance;
        private float interestrate;
        private DateTime createddate;
        private string renewaloption;
        private DateTime duedate;

        public int Savingaccountid { get => savingaccountid; set => savingaccountid = value; }
        public string Customerid { get => customerid; set => customerid = value; }
        public string Balance { get => balance; set => balance = value; }
        public float Interestrate { get => interestrate; set => interestrate = value; }
        public DateTime Createddate { get => createddate; set => createddate = value; }
        public string Renewaloption { get => renewaloption; set => renewaloption = value; }
        public DateTime Duedate { get => duedate; set => duedate = value; }

        public SavingAccount() { }
        
        public SavingAccount(int savingaccountid, string customerid, string balance, float interestrate, DateTime createddate, string renewaloption,DateTime duedate)
        {
            Savingaccountid = savingaccountid;
            Customerid = customerid;
            Balance = balance;
            Interestrate = interestrate;
            Createddate = createddate;
            Renewaloption = renewaloption;
            Duedate = duedate;
        }
        public SavingAccount( string customerid, string balance, float interestrate, DateTime createddate, string renewaloption)
        {
            Customerid = customerid;
            Balance = balance;
            Interestrate = interestrate;
            Createddate = createddate;
            Renewaloption = renewaloption;
        }
        public SavingAccount(string customerid)
        {
            Customerid= customerid;
        }
        ~SavingAccount() { }
    }
}
