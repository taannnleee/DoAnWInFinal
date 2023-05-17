using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnWinDows.BusinessLayer.Models
{
    public class CreditDetails
    {
        private string cvvcode;
        private DateTime transactiondate;
        private string transactionamount;
        private string description;

        public string CvvCode { get => cvvcode; set => cvvcode = value; }
        public DateTime Transactiondate{ get => transactiondate; set => transactiondate = value; }
        public string TransactionAmount { get => transactionamount; set => transactionamount = value; }
        public string Description { get => description; set => description = value; }

        public CreditDetails(string cvvcode,DateTime transactiondate, string transactionamount, string description) 
        {
            CvvCode = cvvcode;
            Transactiondate = transactiondate;
            TransactionAmount = transactionamount;
            Description = description;
        }
    }
}
