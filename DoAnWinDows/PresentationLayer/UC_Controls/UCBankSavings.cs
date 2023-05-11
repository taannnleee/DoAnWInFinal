using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnWinDows.BusinessLayer.Models;
using DoAnWinDows.DataAccessObject;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace DoAnWinDows
{
    public partial class UCBankSavings : UserControl
    {
        Customer customer = new Customer();
        EmployeeDao emDAO = new EmployeeDao();
        SavingAccountDAO savingaccountDao = new SavingAccountDAO();
        SavingAccount SavingAccount_Select = new SavingAccount();
        CustomerAccountDAO customerAccountDao = new CustomerAccountDAO();
        CustomerAccount customerAccount = new CustomerAccount();
        SavingAccount savingAccount = new SavingAccount();
        public UCBankSavings()
        {

            InitializeComponent();
        }
        private void LoadDanhSach()
        {
            //AutoRenewSavingsAccounts();
            this.gvQuanLy.DataSource = savingaccountDao.ListBankPassBook();
        }

        private void UCBankSavings_Load(object sender, EventArgs e)
        {
            LoadDanhSach();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            float interest = float.Parse(cboInterestRate.SelectedItem.ToString().Substring(cboInterestRate.SelectedItem.ToString().Length - 4, 3));
            string rdbtn = rdbtnPrincipalAutoRenew.Checked ? rdbtnPrincipalAutoRenew.Text : rdbtnAutoRenew.Checked ? rdbtnAutoRenew.Text : rdbtnAutoClose.Checked ? rdbtnAutoClose.Text : "";
            SavingAccount savingAccount = new SavingAccount(customerAccount.Customerid, txtAmount.Text, interest, dtpCreatedDate.Value, rdbtn);
            savingAccount.Duedate = savingAccount.Createddate.AddDays(CheckMaturityDate(savingAccount));
            savingaccountDao.Them(savingAccount);
            LoadDanhSach();
        }

        private void btnTatToan_Click(object sender, EventArgs e)
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
                MessageBox.Show("Ban da tat toan thanh cong! Ban nhan duoc(goc va lai): "+SavingAccount_Select.Balance.ToString(), "Thanh cong", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.gvQuanLy.DataSource = savingaccountDao.Search(txtSearch.Text);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDanhSach();
        }

        private void btnInterest_Click(object sender, EventArgs e)
        {
            SavingAccount_Select.Balance = gvQuanLy.SelectedRows[0].Cells["Balance"].Value.ToString();
            SavingAccount_Select.Interestrate = float.Parse(gvQuanLy.SelectedRows[0].Cells["InterestRate"].Value.ToString());
            string a = (int.Parse(SavingAccount_Select.Balance.ToString()) * SavingAccount_Select.Interestrate / 100).ToString();
            MessageBox.Show("So tien lai la: " + a, "Anounce", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            emDAO.SearchCustomer(customer, customerAccount, txtAccountNumber);
            rtxtInformation.Clear();
            if (customerAccountDao.IsIDExist(customerAccount) == false)
                MessageBox.Show("Khong tim thay!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                rtxtInformation.Text += "THONG TIN KHACH HANG\n";
                rtxtInformation.Text += "Ten khach hang: " + customer.Customername + "\n";
                rtxtInformation.Text += "So tai khoan: " + customerAccount.Accountnumber + "\n";
                rtxtInformation.Text += "Loai tai khoan: " + customerAccount.Accounttype + "\n";
                rtxtInformation.Text += "So du: " + customerAccount.Balance + "\n\n";
            }
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
    }
}
