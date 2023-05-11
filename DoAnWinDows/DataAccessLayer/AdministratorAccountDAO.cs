using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnWinDows.BusinessLayer.Models;
using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
using DoAnWinDows.Utilities;

namespace DoAnWinDows.DataAccessLayer
{
    public class AdministratorAccountDAO
    {
        DBConnection dbconnect = new DBConnection();
        public DataTable DanhSachQuanLy()
        {
            string sqlStr = string.Format("Select * From AdministratorAccount");
            return dbconnect.DanhSach(sqlStr);
        }

        public void Them(AdminAccount account)
        {
            string sqlStr = string.Format("Insert into AdministratorAccount(FullName,Phone,Pass,IdentityCard,Email,Address_,DateOfBirth,Gender,CreatedTime,LastLoginTime)values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')", account.Name, account.Phone, account.Password, account.Identitycard, account.Email, account.Address, account.Dateofbirth, account.Gender, account.Createdtime, account.Lastlogintime);
            dbconnect.ThucThi(sqlStr);
        }

        public void Xoa(AdminAccount account)
        {
            string sqlStr = string.Format("DELETE FROM AdministratorAccount WHERE IdentityCard = '{0}'", account.Identitycard);          
            dbconnect.ThucThi(sqlStr);
        }

        public void Sua(AdminAccount account)
        {
            string sqlStr = string.Format("UPDATE AdministratorAccount SET FullName = '{0}',Phone = '{1}',Pass ='{2}',Email='{3}',Address_='{4}',DateOfBirth='{5}',Gender='{6}'where IdentityCard='{7}'", account.Name, account.Phone, account.Password, account.Email, account.Address, account.Dateofbirth, account.Gender, account.Identitycard);
            dbconnect.ThucThi(sqlStr);
        }

        public DataTable Search(CustomerAccount account)
        {
            string sqlStr = string.Format("Select * From AdministratorAccount WHERE IdentityCard = '{0}'", account.Username);
            return dbconnect.DanhSach(sqlStr);
        }

        public void LoadRowInAdminAccountTable(DataGridView dgv, string[] columnNames, Dictionary<string, Control> textBoxMapping)
        {
            LoadRowData.LoadSelectedRowData(dgv, columnNames, textBoxMapping);
        }
    }
}
