using System.Data.SqlClient;
using DoAnWinDows.BusinessLayer.Models;
using DoAnWinDows.DataAccessLayer;
using DoAnWinDows.DataAccessObject;
using DoAnWinDows.PresentationLayer.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoAnWinDows
{
    public partial class FLogin : Form
    {
        SavingAccountDAO savingaccountDao = new SavingAccountDAO();
        public FLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginDAO loginDao = new LoginDAO();
            CustomerAccount account = new CustomerAccount(txtUserName.Text, txtPassWord.Text);
            AdminAccount adminaccount = new AdminAccount(txtUserName.Text, txtPassWord.Text);
            EmployeeAccount employeeaccount = new EmployeeAccount(txtUserName.Text, txtPassWord.Text);
            if (cboDecentralization.SelectedIndex == 0)
            {
                if (loginDao.CheckManagementAccount(adminaccount))
                {
                    FManager quanly = new FManager();
                    quanly.Show();
                    account.Lastlogintime = DateTime.Now;
                    loginDao.UpdateDate(adminaccount);
                }
                else
                {
                    MessageBox.Show("Mat khau hoac tai khoan sai");
                }
            }
            else
            {
                if (loginDao.CheckEmployeeAccount(employeeaccount))
                {
                    FEmployee emp = new FEmployee();
                    emp.Show();
                }
                else
                {
                    MessageBox.Show("Mat khau hoac tai khoan sai");
                }
            }
        }
        private void AutoRenewSavingsAccounts()
        {
            List<SavingAccount> savingsAccounts = savingaccountDao.GetSavingsAccounts();

            foreach (SavingAccount account in savingsAccounts)
            {
                if (account.Renewaloption == "Principal Auto Renew")
                {
                    if (DateTime.Today >= account.Createddate.AddDays(CheckMaturityDate(account)))
                    {
                        float interestAmount = int.Parse(account.Balance) / 100 * account.Interestrate;
                        account.Createddate = account.Createddate.AddDays(CheckMaturityDate(account));
                        account.Duedate = account.Createddate.AddDays(CheckMaturityDate(account));
                        savingaccountDao.GiaHanGoc(account, interestAmount);
                    }
                }
                else if (account.Renewaloption == "Auto Renew")
                {
                    if (DateTime.Today >= account.Createddate.AddDays(CheckMaturityDate(account)))
                    {
                        float interestAmount = int.Parse(account.Balance) / 100 * account.Interestrate;
                        account.Balance = (int.Parse(account.Balance) + interestAmount).ToString();
                        account.Createddate = account.Createddate.AddDays(CheckMaturityDate(account));
                        account.Duedate = account.Createddate.AddDays(CheckMaturityDate(account));
                        savingaccountDao.Sua(account);
                    }
                }
                else if (account.Renewaloption == "Auto Close")
                {
                    if (DateTime.Today >= account.Createddate.AddDays(CheckMaturityDate(account)))
                    {
                        float interestAmount = int.Parse(account.Balance) / 100 * account.Interestrate;
                        account.Balance = (int.Parse(account.Balance) + interestAmount).ToString();
                        savingaccountDao.TatToan(account);
                    }

                }
            }
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

        private void cboDecentralization_MouseEnter(object sender, EventArgs e)
        {
            cboDecentralization.Select(0, 0);
        }

        private void FLogin_Load(object sender, EventArgs e)
        {
            string status = "Expired";
            CreditCardDAO credit = new CreditCardDAO();
            List<CreditCard> lcreditcard = credit.GetExpirationDate();

            foreach (CreditCard curentcredit in lcreditcard)
            {
                credit.UpdateExpirationDate(curentcredit.Cvvcode, status);
            }
        }
    }
}