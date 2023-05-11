using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnWinDows.BusinessLayer.Models
{
    internal class MortgageLoan_CustomerAccount
    {
        private int loanID;
        private int accountNumber;
        private string customerName;
        private string loanAmount;
        private int loanPeriod;
        private string collateral;
        private string loanPayable;
        private string loanStatus;
        private DateTime startLoan;
        private DateTime endLoan;

        public int LoanID
        {
            get { return loanID; }
            set { loanID = value; }
        }

        public int AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }

        public string LoanAmount
        {
            get { return loanAmount; }
            set { loanAmount = value; }
        }

        public string Collateral
        {
            get { return collateral; }
            set { collateral = value; }
        }

        public int LoanPeriod
        {
            get { return loanPeriod; }
            set { loanPeriod = value; }
        }

        public string LoanPayable
        {
            get { return loanPayable; }
            set { loanPayable = value; }
        }

        public string LoanStatus
        {
            get { return loanStatus; }
            set { loanStatus = value; }
        }

        public DateTime StartLoan
        {
            get { return startLoan; }
            set { startLoan = value; }
        }

        public DateTime EndLoan
        {
            get { return endLoan; }
            set { endLoan = value; }
        }

        public MortgageLoan_CustomerAccount() { }

        public MortgageLoan_CustomerAccount(int loanID, int accountNumber, string customerName, string loanAmount, int loanPeriod, string collateral,string loanPayable, string loanStatus, DateTime startLoan, DateTime endLoan)
        {
            this.loanID = loanID;
            this.accountNumber = accountNumber;
            this.customerName = customerName;
            this.loanAmount = loanAmount;
            this.loanPeriod = loanPeriod;
            this.loanPayable = loanPayable;
            this.loanStatus = loanStatus;
            this.startLoan = startLoan;
            this.endLoan = endLoan;
            this.collateral = collateral;
        }

        public static string Payable(string amount, string period)
        {
            return (long.Parse(amount) + ((long.Parse(amount) * long.Parse(period) * 2) / 100)).ToString();
        }
    }
}
