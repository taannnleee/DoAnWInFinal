using DoAnWinDows.BusinessLayer.Models;
using DoAnWinDows.DataAccessLayer;
using DoAnWinDows.DataAccessObject;
using DoAnWinDows.Utilities;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnWinDows.PresentationLayer.UC_Controls
{
    public partial class UC_Unsecure_Loan : UserControl
    {
        public UC_Unsecure_Loan()
        {
            InitializeComponent();
        }

        Customer customer = new Customer();
        CustomerAccount customerAccount = new CustomerAccount();
        EmployeeDao employeeDAO = new EmployeeDao();
        CustomerAccountDAO customerAccountDAO = new CustomerAccountDAO();

        private void ShowAccountInformation()
        {
            richTextBoxInformation.Clear();
            richTextBoxInformation.Text += "LOAN INFORMATION\n";
            richTextBoxInformation.Text += "NAME: " + customer.Customername + "\n";
            richTextBoxInformation.Text += "ACCOUNT NUMBER: " + customerAccount.Accountnumber + "\n";
            richTextBoxInformation.Text += "ACCOUNT TYPE: " + customerAccount.Accounttype + "\n\n";
        }

        private void ShowLoanInformation()
        {
            richTextBoxInformation.Text += "lOAN TYPE: UNSECURE LOAN\n";
            richTextBoxInformation.Text += "LOAN ID: " + txtLoanID.Text + "\n";
            richTextBoxInformation.Text += "LOAN AMOUNT: " + txtLoanAmount.Text + "\n";
            richTextBoxInformation.Text += "PERIOD: " + comboBoxLoanPeriod.Text + "\n";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            employeeDAO.SearchCustomer(customer, customerAccount, txtAccountNumber);
            ShowAccountInformation();
            txtAccountNumber.Text = null;
        }

        private void UC_Unsecure_Loan_Load(object sender, EventArgs e)
        {
            richTextBoxInformation.Clear();
            richTextBoxInformation.Text += "LOAN INFORMATION";
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            try
            {
                if (DAO_UnsecureLoan.IDisExisted(txtLoanID) == false)
                {
                    string payable = UnsecureLoan_CustomerAccount.Payable(txtLoanAmount.Text, comboBoxLoanPeriod.Text);
                    DateTime current = DateTime.Now;
                    DateTime endLoan = current.AddYears(int.Parse(comboBoxLoanPeriod.Text));
                    UnsecureLoan_CustomerAccount unsecureLoan_customerAccount = new UnsecureLoan_CustomerAccount(int.Parse(txtLoanID.Text), customerAccount.Accountnumber, customer.Customername, txtLoanAmount.Text, Convert.ToInt32(comboBoxLoanPeriod.Text), payable, "Unpaid", current, endLoan);
                    ShowLoanInformation();
                    txtLoanAmount.Text = null;
                    txtLoanID.Text = null;
                    comboBoxLoanPeriod.Text = null;
                    DAO_UnsecureLoan.Add(unsecureLoan_customerAccount);
                    customerAccount.Balance = Calculation.AddStrings(customerAccount.Balance, unsecureLoan_customerAccount.LoanAmount);
                    customerAccountDAO.Edit(customerAccount, customer);
                }
                else
                {
                    MessageBox.Show("ID da ton tai. Xin vui long chon ID khac.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            richTextBoxInformation.Clear();
            UC_Unsecure_Loan_Load(sender, e);
        }
    }
}
