using DoAnWinDows.BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnWinDows.DataAccessLayer;

namespace DoAnWinDows.DataAccessLayer
{
    public class TransactionDAO
    {
        DBConnection dbconnect = new DBConnection();
        public bool Them(Transactions transaction)
        {
            string sqlStr = string.Format("Insert into Transactions(SendingAccountNumber,ReceivingAccountNumber,Amount,TransactionDay,TransactionStatus,Fee,TransferContent,EmployeeID)values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", transaction.SendingAccountNumber,transaction.Receivingaccountnumber,transaction.Amount,transaction.Transactionday,transaction.Transactionstatus,transaction.Fee,transaction.Transfercontent,transaction.Employeeid);
            return dbconnect.ThucThi(sqlStr);
        }
    }
}
