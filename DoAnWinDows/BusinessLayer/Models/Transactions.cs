using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnWinDows.BusinessLayer.Models
{
    public class Transactions
    {

        private int sendingaccountnumber;
        private int receivingaccountnumber;
        private string amount;
        private DateTime transactionday;
        private string transactionstatus;
        private string fee;
        private string transfercontent;
        private string employeeid;

        public int SendingAccountNumber { get => sendingaccountnumber; set => sendingaccountnumber = value; }
        public string Amount { get => amount; set => amount = value; }
        public DateTime Transactionday { get => transactionday; set => transactionday = value; }
        public string Transactionstatus { get => transactionstatus; set => transactionstatus = value; }
        public string Fee { get => fee; set => fee = value; }
        public string Transfercontent { get => transfercontent; set => transfercontent = value; }
        public string Employeeid { get => employeeid; set => employeeid = value; }
        public int Receivingaccountnumber { get => receivingaccountnumber; set => receivingaccountnumber = value; }

        public Transactions() { }

        public Transactions(int sendingaccountnumber, int receivingaccountnumber, string amount, DateTime transactionday, string transactionstatus, string fee, string transfercontent, string employeeid)
        {
            this.sendingaccountnumber = sendingaccountnumber;
            this.receivingaccountnumber = receivingaccountnumber;
            this.amount = amount;
            this.transactionday = transactionday;
            this.transactionstatus = transactionstatus;
            this.fee = fee;
            this.transfercontent = transfercontent;
            this.employeeid = employeeid;
        }
    }
}
