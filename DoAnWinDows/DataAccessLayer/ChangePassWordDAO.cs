using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnWinDows.BusinessLayer.Models;
using DoAnWinDows.DataAccessObject;

namespace DoAnWinDows.DataAccessLayer
{
    public class ChangePassWordDAO
    {
        DBConnection dbconnect = new DBConnection();
        public bool CheckCustomerAccount(string captcha, string txtcaptcha)
        {
            if (captcha.Equals(txtcaptcha))
            {
                return true;
            }
            return false;

        }

        public void ChangePassword(CustomerAccount account)
        {
            string sqlStr = string.Format("UPDATE CustomerLogin SET PassWord ='{0}' where UserName='{1}'", account.Password, account.Username);
            dbconnect.ThucThi(sqlStr);
        }

        public bool IsCvvtExists(CustomerAccount account)
        {
            string sqlStr = string.Format("SELECT COUNT(*) FROM CustomerLogin WHERE UserName = '{0}' and PassWord = '{1}' ", account.Username, account.Password);
            return dbconnect.IsExist(sqlStr);
        }

        public DataTable AccountCustomerList()
        {
            string sqlStr = string.Format("Select * From CustomerLogin");
            return dbconnect.DanhSach(sqlStr);
        }
    }
}
