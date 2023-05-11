using DoAnWinDows.BusinessLayer.Models;
using DoAnWinDows.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DoAnWinDows.DataAccessObject
{
    public class LoginDAO
    {
        DBConnection conn = new DBConnection();
        public bool CheckManagementAccount(AdminAccount adminaccount)
        {
            string sqlStr = string.Format("SELECT COUNT(*) FROM AdministratorAccount WHERE Phone = '{0}' AND Pass = '{1}'", adminaccount.Phone, adminaccount.Password);
            return conn.IsExist(sqlStr);
        }

        public bool CheckCustomerAccount(CustomerAccount account)
        {
            string sqlStr = string.Format("SELECT COUNT(*) FROM CustomerLogin WHERE UserName = '{0}' AND PassWord = '{1}'", account.Username, account.Password);
            return conn.IsExist(sqlStr);
        }

        public bool CheckEmployeeAccount(EmployeeAccount empAcc)
        {
            string sqlStr = string.Format("SELECT COUNT(*) FROM EmployeeLogin WHERE UserName = '{0}' AND PassWord = '{1}'", empAcc.Username, empAcc.Password);
            return conn.IsExist(sqlStr);
        }

        public void UpdateDate(AdminAccount adminaccount)
        {
            string sqlStr = string.Format("UPDATE AdministratorAccount SET LastLoginTime  = '{0}' WHERE Pass = '{1}'", adminaccount.Lastlogintime, adminaccount.Password);
            conn.ThucThi(sqlStr);
        }
    }
}
