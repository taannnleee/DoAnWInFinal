using DoAnWinDows.BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnWinDows.DataAccessLayer;
using System.Data.SqlClient;
using DoAnWinDows.Helpers;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DoAnWinDows.Utilities;

namespace DoAnWinDows.PresentationLayer.UC_Controls
{
    public partial class UCCreateCreditCard : UserControl
    {
        CreditCardDAO reditcardDAO = new CreditCardDAO();
        private string limitmoney;
        bool inforCollapsed;
        public UCCreateCreditCard()
        {
            InitializeComponent();
        }

        public void LoadBorrowAccount()
        {

            SqlDataReader reader = reditcardDAO.GetDataDefaultAccount(txtUserName.Text, txtPassWord.Text);
            if (reader != null)
            {
                txtAccountNumber.Text = reader["AccountNumber"].ToString();
                txtCustomerID.Text = reader["CustomerID"].ToString();
                cboAccountType.Text = reader["AccountType"].ToString();
                txtBalance.Text = reader["Balance"].ToString();
                txtAcountStatus.Text = reader["AccountStatus"].ToString();
                txtAddress.Text = reader["Address"].ToString();
                txtCustomerName.Text = reader["CustomerName"].ToString();
                txtIdentitycard.Text = reader["IdentityCard"].ToString();
                cboGender.Text = reader["Gender"].ToString();
                txtPhoneNumber.Text = reader["PhoneNumber"].ToString();
                txtEmail.Text = reader["Email"].ToString();
                reader.Close();
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            CustomerAccount customerAccount = new CustomerAccount(txtUserName.Text, txtPassWord.Text);
            if (reditcardDAO.IsCreditAccountExists(customerAccount))
            {
                string input = Microsoft.VisualBasic.Interaction.InputBox("Enter credit card limit amount:", "Notification", "");
                if (!string.IsNullOrEmpty(input))
                {
                    limitmoney = input;
                    LoadBorrowAccount();
                    btnAdd_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Account don't exist");
            }
        }

        public void LoadDanhSach()
        {
            this.gvCreditCard.DataSource = reditcardDAO.DanhSachQuanLy();
        }

        private void UCCreditCard_Load(object sender, EventArgs e)
        {
            LoadDanhSach();
        }

        public void getData(CreditCard credit)
        {
            DateTime dateTime = Time.GetCurrentTime();
            SqlDataReader reader = reditcardDAO.GetDataCredit(Convert.ToInt32(txtAccountNumber.Text));
            if (reader != null)
            {
                credit.Accountnumber = Convert.ToInt32(reader["AccountNumber"]);
            }
            credit.Creditlimit = limitmoney;
            credit.Moneyspent = "0";
            credit.Datecreated = dateTime;
            credit.Expirationdate = dateTime.AddDays(30);
            credit.Cvvcode = RanDom.RandomCharacters();
            while (reditcardDAO.IsCvvtExists(credit.Cvvcode))
            {
                credit.Cvvcode = RanDom.RandomCharacters();
            }
            credit.CreditCardStatus = "Active";
            credit.OverdueMonths = "0";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CreditCard credit = new CreditCard();
            getData(credit);
            limitmoney = null;
            if (reditcardDAO.Them(credit))
            {
                MessageBox.Show("Success");
                Infortimer.Start();
                inforContainer.Visible = true;
                ClearText.ClearAll(this.Controls);
            }
            else
            {
                MessageBox.Show("Fail");
            }
            LoadDanhSach();
        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            if (txtUserName.Text == "UserName")
            {
                txtUserName.Text = "";
            }
        }

        private void txtPassWord_Enter(object sender, EventArgs e)
        {
            if (txtPassWord.Text == "PassWord")
            {
                txtPassWord.Text = "";
            }
        }

        private void Infortimer_Tick(object sender, EventArgs e)
        {
            if (inforCollapsed)
            {
                inforContainer.Left += 10;
                inforContainer.Width -= 10;
                if (inforContainer.Width == inforContainer.MinimumSize.Width)
                {
                    inforCollapsed = false;
                    Infortimer.Stop();
                }
            }
            else
            {
                inforContainer.Left -= 10;
                inforContainer.Width += 10;
                if (inforContainer.Width == inforContainer.MaximumSize.Width)
                {
                    inforCollapsed = true;
                    Infortimer.Stop();
                }
            }
        }

        private void btnArrow_Click(object sender, EventArgs e)
        {
            Infortimer.Start();
        }
    }
}
