using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnWinDows.BusinessLayer.Models
{
    public class CreditCard
    {
        private int creditcardid;
        private DateTime expirationdate;
        private string creditlimit;
        private string moneyspent;
        private DateTime datecreated;
        private int accountnumber;
        private string cvvcode;
        private string creditcardstatus;
        private string overduemonths;
        public DateTime Expirationdate { get => expirationdate; set => expirationdate = value; }
        public string Creditlimit { get => creditlimit; set => creditlimit = value; }
        public DateTime Datecreated { get => datecreated; set => datecreated = value; }
        public int Accountnumber { get => accountnumber; set => accountnumber = value; }
        public int Creditcardid { get => creditcardid; set => creditcardid = value; }
        public string Cvvcode { get => cvvcode; set => cvvcode = value; }
        public string Moneyspent { get => moneyspent; set => moneyspent = value; }
        public string CreditCardStatus { get => creditcardstatus; set => creditcardstatus = value; }
         public string OverdueMonths { get => overduemonths; set => overduemonths = value; }


        public CreditCard() { }

        public CreditCard(DateTime expirationdate, string creditlimit, string moneyspent, DateTime datecreated, int accountnumber,string cvvcode,string creditcardstatus, string overduemonths)
        {
            Expirationdate = expirationdate;
            Creditlimit = creditlimit;
            Moneyspent = moneyspent;
            Datecreated = datecreated;
            Accountnumber = accountnumber;
            Cvvcode = cvvcode;
            CreditCardStatus = creditcardstatus;
            OverdueMonths = overduemonths;
        }

        public CreditCard(string cvvcode)
        {
            Cvvcode = cvvcode;
        }

        public CreditCard(string cvvcode,string moneyspent)
        {            
            Cvvcode = cvvcode;
            Moneyspent = moneyspent;
        }

    }
}
