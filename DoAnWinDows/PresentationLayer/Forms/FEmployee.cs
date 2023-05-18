using DoAnWinDows.BusinessLayer.Models;
using DoAnWinDows.DataAccessLayer;
using DoAnWinDows.PresentationLayer.UC_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnWinDows.PresentationLayer.Forms
{
    public partial class FEmployee : Form
    {
        bool sidebarExpand;
        bool homeCollapsed;
        public FEmployee()
        {
            InitializeComponent();
        }
        public void AddUserControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panelEmployee.Controls.Clear();
            panelEmployee.Controls.Add(uc);
            uc.BringToFront();
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void Hometimer_Tick(object sender, EventArgs e)
        {
            if (homeCollapsed)
            {
                homeContainer.Height += 10;
                if (homeContainer.Height == homeContainer.MaximumSize.Height)
                {
                    homeCollapsed = false;
                    Hometimer.Stop();
                }
            }
            else
            {
                homeContainer.Height -= 10;
                if (homeContainer.Height == homeContainer.MinimumSize.Height)
                {
                    homeCollapsed = true;
                    Hometimer.Stop();
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Hometimer.Start();
        }

        private void btnCreditCard_Click(object sender, EventArgs e)
        {
            UCMenuCreditCard menuCrdi = new UCMenuCreditCard();
            AddUserControl(menuCrdi);
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            UCTransactions trans = new UCTransactions();
            AddUserControl(trans);
        }

        private void btnRecharge_Click(object sender, EventArgs e)
        {
            UCRecharge recharge = new UCRecharge();
            AddUserControl(recharge);
        }

        private void btnWithDraw_Click(object sender, EventArgs e)
        {
            UCWithdraw withdraw = new UCWithdraw();
            AddUserControl(withdraw);
        }

        private void btnBankSavings_Click(object sender, EventArgs e)
        {
            UCBankSavings banksavings = new UCBankSavings();
            banksavings.Dock = DockStyle.Fill;
            AddUserControl(banksavings);
        }

        private void btnTypeLoan_Click(object sender, EventArgs e)
        {
            UCMenuLoan menuLoan = new UCMenuLoan();
            AddUserControl(menuLoan);
        }

        private void btnSettingPassWord_Click(object sender, EventArgs e)
        {
            UCChangePassword changepass = new UCChangePassword();
            AddUserControl(changepass);
        }

        private void FEmployee_Load(object sender, EventArgs e)
        {
            string onemonth = "1";
            string twomonth = "2";
            string moremonth = "3";
            DateTime current = Time.GetCurrentTime();
            string status = "Expired";
            CreditCardDAO credit = new CreditCardDAO();
            List<CreditCard> lcreditcard = credit.GetExpirationDate();

            foreach (CreditCard curentcredit in lcreditcard)
            {
                TimeSpan duration = current - curentcredit.Expirationdate;
                int numberOfDays = (int)duration.TotalDays;
                DateTime newdayexpira = curentcredit.Expirationdate.AddDays(1);
                if (current > newdayexpira)
                {
                    credit.UpdateExpirationDate(curentcredit.Cvvcode, status);
                }
                if (numberOfDays >= 1 && numberOfDays <= 30)
                {
                    credit.UpdateOverdueMonths(curentcredit.Cvvcode, onemonth);
                }
                else if (numberOfDays >= 31 && numberOfDays <= 60)
                {
                    credit.UpdateOverdueMonths(curentcredit.Cvvcode, twomonth);
                }
                else if (numberOfDays >= 61)
                {
                    credit.UpdateOverdueMonths(curentcredit.Cvvcode, moremonth);
                }
            }
        }
    }
}

