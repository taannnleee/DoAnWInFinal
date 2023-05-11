using DoAnWinDows.BusinessLayer.Models;
using DoAnWinDows.DataAccessObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DoAnWinDows
{
    public partial class Cus_UCBankSavings : UserControl
    {
        SavingAccount SavingAccount_Select = new SavingAccount();
        private CustomerAccount customerAcc;
        SavingAccountDAO savingaccountDao = new SavingAccountDAO();
        public Cus_UCBankSavings(CustomerAccount acc)
        {
            customerAcc = acc;
            InitializeComponent();
        }
        private void Cus_UCBankSavings_Load(object sender, EventArgs e)
        {
            LoadDanhSach();
        }
        private void LoadDanhSach()
        {
            this.gvQuanLy.DataSource = savingaccountDao.Search(customerAcc.Accountnumber.ToString());
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            float interest = float.Parse(cboInterestRate.SelectedItem.ToString().Substring(cboInterestRate.SelectedItem.ToString().Length - 4, 3));
            string rdbtn = rdbtnPrincipalAutoRenew.Checked ? rdbtnPrincipalAutoRenew.Text : rdbtnAutoRenew.Checked ? rdbtnAutoRenew.Text : rdbtnAutoClose.Checked ? rdbtnAutoClose.Text : "";
            SavingAccount savingAccount = new SavingAccount(customerAcc.Customerid, txtAmount.Text, interest, dtpCreatedDate.Value, rdbtn);
            savingAccount.Duedate = savingAccount.Createddate.AddDays(CheckMaturityDate(savingAccount));
            savingaccountDao.Them(savingAccount);
            LoadDanhSach();
        }
        public int CheckMaturityDate(SavingAccount savingAccount)
        {
            if (savingAccount.Interestrate == 3)
                return 90;
            else if (savingAccount.Interestrate == 3.5)
                return 180;
            else if (savingAccount.Interestrate == 4)
                return 270;
            else if (savingAccount.Interestrate == 4.5)
                return 360;
            return 0;
        }
        //private void AutoRenewSavingsAccounts()
        //{
        //    // Lấy danh sách tài khoản tiết kiệm
        //    List<SavingAccount> savingsAccounts = savingaccountDao.GetSavingsAccounts();

        //    // Lặp qua từng tài khoản tiết kiệm để kiểm tra thời gian gia hạn tự động
        //    foreach (SavingAccount account in savingsAccounts)
        //    {
        //        if (account.Renewaloption == "Principal Auto Renew")
        //        {
        //            if (DateTime.Today >= account.Createddate.AddDays(CheckMaturityDate(account)))
        //            {
        //                float interestAmount = int.Parse(account.Balance) / 100 * account.Interestrate;
        //                account.Createddate = account.Createddate.AddDays(CheckMaturityDate(account));
        //                savingaccountDao.GiaHanGoc(account, interestAmount);
        //            }
        //        }
        //        else if (account.Renewaloption == "Auto Renew")
        //        {
        //            if (DateTime.Today >= account.Createddate.AddDays(CheckMaturityDate(account)))
        //            {
        //                float interestAmount = int.Parse(account.Balance) / 100 * account.Interestrate;
        //                account.Balance = (int.Parse(account.Balance) + interestAmount).ToString();
        //                account.Createddate = account.Createddate.AddDays(CheckMaturityDate(account));
        //                savingaccountDao.Sua(account);
        //            }
        //        }
        //        else if (account.Renewaloption == "Auto Close")
        //        {
        //            if (DateTime.Today >= account.Createddate.AddDays(CheckMaturityDate(account)))
        //            {
        //                float interestAmount = int.Parse(account.Balance) / 100 * account.Interestrate;
        //                account.Balance = (int.Parse(account.Balance) + interestAmount).ToString();
        //                savingaccountDao.TatToan(account);
        //            }

        //        }
        //    }
        //}

        private void btnFinalSettlement_Click(object sender, EventArgs e)
        {
            SavingAccount_Select.Savingaccountid = int.Parse(gvQuanLy.SelectedRows[0].Cells["SavingAccountID"].Value.ToString());
            SavingAccount_Select.Customerid = gvQuanLy.SelectedRows[0].Cells["CustomerID"].Value.ToString();
            SavingAccount_Select.Balance = gvQuanLy.SelectedRows[0].Cells["Balance"].Value.ToString();
            SavingAccount_Select.Interestrate = float.Parse(gvQuanLy.SelectedRows[0].Cells["InterestRate"].Value.ToString());
            SavingAccount_Select.Createddate = (DateTime)gvQuanLy.SelectedRows[0].Cells["CreatedDate"].Value;
            SavingAccount_Select.Renewaloption = gvQuanLy.SelectedRows[0].Cells["RenewalOption"].Value.ToString();
            SavingAccount_Select.Duedate = (DateTime)gvQuanLy.SelectedRows[0].Cells["DueDate"].Value;
            if (SavingAccount_Select.Duedate.Subtract(DateTime.Now).TotalDays <= 7)
            {
                SavingAccount_Select.Balance = (int.Parse(gvQuanLy.SelectedRows[0].Cells["Balance"].Value.ToString()) + int.Parse(SavingAccount_Select.Balance.ToString()) * SavingAccount_Select.Interestrate / 100).ToString();
                savingaccountDao.TatToan(SavingAccount_Select);
                MessageBox.Show("Ban da tat toan thanh cong! Ban nhan duoc(goc va lai): " + SavingAccount_Select.Balance.ToString(), "Thanh cong", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show("Chua toi ngay dao han, ban se khong nhan duoc tien lai. Ban co muon tiep tuc khong?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    savingaccountDao.TatToan(SavingAccount_Select);
                else
                    return;
            }
            LoadDanhSach();
        }

        private void btnInterest_Click(object sender, EventArgs e)
        {
            SavingAccount_Select.Balance = gvQuanLy.SelectedRows[0].Cells["Balance"].Value.ToString();
            SavingAccount_Select.Interestrate = float.Parse(gvQuanLy.SelectedRows[0].Cells["InterestRate"].Value.ToString());
            string a = (int.Parse(SavingAccount_Select.Balance.ToString()) * SavingAccount_Select.Interestrate / 100).ToString();
            MessageBox.Show("So tien lai la: " + a, "Anounce", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
