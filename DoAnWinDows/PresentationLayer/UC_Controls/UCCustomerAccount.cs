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
using DoAnWinDows.Helpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DoAnWinDows
{
    public partial class UCCustomerAccount : UserControl
    {
        CustomerAccountDAO cusAccountDao = new CustomerAccountDAO();
        public UCCustomerAccount()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            CustomerAccount user = new CustomerAccount(txtCustomerID.Text, txtUserName.Text, txtPassWord.Text, int.Parse(txtAccountNumber.Text), txtCustomerID.Text, cboAccountType.SelectedItem.ToString(), txtBalance.Text, txtAcountStatus.Text, Time.GetCurrentTime(), Time.GetCurrentTime());
            Customer info = new Customer(txtCustomerID.Text, txtCustomerName.Text, txtIdentitycard.Text, txtAddress.Text, txtPhoneNumber.Text, cboGender.SelectedItem.ToString(), txtEmail.Text);
            if (cusAccountDao.IsIDExist(user) == false)
            {
                if (cusAccountDao.Inserst(user, info))
                {
                    MessageBox.Show("Thanh Cong");
                }
                else
                {
                    MessageBox.Show("That Bai");
                }
            }
            else
            {
                MessageBox.Show("Customer ID already exists ");
            }
            LoadList();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            CustomerAccount user = new CustomerAccount(txtCustomerID.Text, txtUserName.Text, txtPassWord.Text, int.Parse(txtAccountNumber.Text), txtCustomerID.Text, cboAccountType.SelectedItem.ToString(), txtBalance.Text, txtAcountStatus.Text, Time.GetCurrentTime(), Time.GetCurrentTime());
            Customer info = new Customer(txtCustomerID.Text, txtCustomerName.Text, txtIdentitycard.Text, txtAddress.Text, txtPhoneNumber.Text, cboGender.SelectedItem.ToString(), txtEmail.Text);
            if (cusAccountDao.Edit(user, info))
            {
                MessageBox.Show("Thanh Cong");
            }
            else
            {
                MessageBox.Show("That Bai");
            }
            LoadList();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            CustomerAccount user = new CustomerAccount(txtCustomerID.Text, txtUserName.Text, txtPassWord.Text, int.Parse(txtAccountNumber.Text), txtCustomerID.Text, cboAccountType.SelectedItem.ToString(), txtBalance.Text, txtAcountStatus.Text, Time.GetCurrentTime(), Time.GetCurrentTime());
            Customer info = new Customer(txtCustomerID.Text, txtCustomerName.Text, txtIdentitycard.Text, txtAddress.Text, txtPhoneNumber.Text, cboGender.SelectedItem.ToString(), txtEmail.Text);
            if (cusAccountDao.Delete(user, info))
            {
                MessageBox.Show("Thanh Cong");
            }
            else
            {
                MessageBox.Show("That Bai");
            }
            LoadList();
        }

        private void UCAccountManager_Load(object sender, EventArgs e)
        {
            LoadList();
        }
        private void LoadList()
        {
            this.gvQuanLy.DataSource = cusAccountDao.DanhSachQuanLy();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            CustomerAccount user = new CustomerAccount(txtCustomerID.Text, txtUserName.Text, txtPassWord.Text, int.Parse(txtAccountNumber.Text), txtCustomerID.Text, cboAccountType.SelectedItem.ToString(), txtBalance.Text, txtAcountStatus.Text, Time.GetCurrentTime(), Time.GetCurrentTime());
            Customer info = new Customer(txtCustomerID.Text, txtCustomerName.Text, txtIdentitycard.Text, txtAddress.Text, txtPhoneNumber.Text, cboGender.SelectedItem.ToString(), txtEmail.Text);
            this.gvQuanLy.DataSource = cusAccountDao.Search(user, info);
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            ClearText.ClearAll(this.Controls);
        }

        string[] columnNames1 = { "UserName", "PassWord", "AccountNumber", "CustomerID", "AccountType", "Balance", "AccountStatus", "CreatedTime", "LastLoginTime", "CustomerName", "IdentityCard", "Address", "PhoneNumber", "Gender", "Email" };

        private Dictionary<string, Control> PairData()
        {
            Dictionary<string, Control> textBoxMapping = new Dictionary<string, Control>
            {
                { "UserName", txtUserName },
                { "PassWord",  txtPassWord  },
                { "AccountNumber", txtAccountNumber },
                { "CustomerID", txtCustomerID },
                { "AccountType", cboAccountType },
                { "Balance", txtBalance },
                { "AccountStatus", txtAcountStatus },


                { "CustomerName", txtCustomerName },
                { "IdentityCard", txtIdentitycard },
                { "Address", txtAddress },
                { "PhoneNumber", txtPhoneNumber },
                { "Gender", cboGender },
                { "Email", txtEmail }
            };
            return textBoxMapping;
        }

        private void gvQuanLy_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            cusAccountDao.LoadRowInAccountTable(gvQuanLy, columnNames1, PairData());
        }
    }
}
