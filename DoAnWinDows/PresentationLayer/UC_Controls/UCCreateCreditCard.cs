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
        public UCCreateCreditCard()
        {
            InitializeComponent();
        }

        public void LoadBorrowAccount()
        {
           
            SqlDataReader reader = reditcardDAO.GetDataDefaultAccount(txtUserName.Text,txtPassWord.Text);
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
                LoadBorrowAccount();
                MessageBox.Show("Success");
            }
            else
            {
                MessageBox.Show("Account don't exist");
            }
        }

        public void LoadDanhSach()
        {
            gvCreditCard.DataSource = reditcardDAO.DanhSachQuanLy();
        }

        private void UCCreditCard_Load(object sender, EventArgs e)
        {
            this.gvCreditCard.DataSource = reditcardDAO.DanhSachQuanLy();
        }

        public void getDataCredit(CreditCard credit)
        {            
            DateTime dateTime = Time.GetCurrentTime();
            SqlDataReader reader = reditcardDAO.GetDataCredit(Convert.ToInt32(txtAccountNumber.Text));
            if(reader != null)
            {
                credit.Accountnumber = Convert.ToInt32(reader["AccountNumber"]);
                credit.Creditlimit = (Convert.ToInt32(reader["Balance"]) / 2).ToString();
            }
            credit.Moneyspent = "0";
            credit.Datecreated = dateTime;
            credit.Expirationdate = dateTime.AddDays(30);
            credit.Cvvcode = RanDom.RandomCharacters();
            while (reditcardDAO.IsCvvtExists(credit.Cvvcode))
            {
                credit.Cvvcode = RanDom.RandomCharacters();
            }
        }

        private bool isTextBoxVisible = true;

        private void btnMore_Click(object sender, EventArgs e)
        {
            if (isTextBoxVisible)
            {
                btnMore.Text = "More";
                txtAccountNumber.Visible = false;
                txtAcountStatus.Visible = false;
                txtAddress.Visible = false;
                txtBalance.Visible = false;
                txtCustomerID.Visible = false;
                txtEmail.Visible = false;
                txtIdentitycard.Visible = false;
                txtPhoneNumber.Visible = false;
                txtCustomerName.Visible = false;
                cboGender.Visible = false;
                cboAccountType.Visible = false;

                lblAccountNumber.Visible = false;
                lblAccountStatus.Visible = false;
                lblAddress.Visible = false;
                lblBalance.Visible = false;
                lblCustomerID.Visible = false;
                lblEmail.Visible = false;
                lblIdentitycard.Visible = false;
                lblPhoneNumber.Visible = false;
                lblCustomerName.Visible = false;
                lblGender.Visible = false;
                lblAccountType.Visible = false;
                isTextBoxVisible = false;
            }
            else
            {
                btnMore.Text = "Less";
                txtAccountNumber.Visible = true;
                txtAcountStatus.Visible = true;
                txtAddress.Visible = true;
                txtBalance.Visible = true;
                txtCustomerID.Visible = true;
                txtEmail.Visible = true;
                txtIdentitycard.Visible = true;
                txtPhoneNumber.Visible = true;
                txtCustomerName.Visible = true;
                cboGender.Visible = true;
                cboAccountType.Visible = true;

                lblAccountNumber.Visible = true;
                lblAccountStatus.Visible = true;
                lblAddress.Visible = true;
                lblBalance.Visible = true;
                lblCustomerID.Visible = true;
                lblEmail.Visible = true;
                lblIdentitycard.Visible = true;
                lblPhoneNumber.Visible = true;
                lblCustomerName.Visible = true;
                lblGender.Visible = true;
                lblAccountType.Visible = true;
                isTextBoxVisible = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CreditCard credit = new CreditCard();
            getDataCredit(credit);
            if (reditcardDAO.Them(credit))
            {
                MessageBox.Show("Thanh Cong");
                ClearText.ClearAll(this.Controls);
            }
            else
            {
                MessageBox.Show("That Bai");
            }
            LoadDanhSach();
        }
    }
}
