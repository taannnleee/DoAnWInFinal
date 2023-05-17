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
    public partial class UCMenuCreditCard : UserControl
    {
        public UCMenuCreditCard()
        {
            InitializeComponent();
        }

        public void AddUserControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            rechargeCredit.Controls.Clear();
            rechargeCredit.Controls.Add(uc);
            uc.BringToFront();
        }

        private void toolStripMenuCreateCredit_Click(object sender, EventArgs e)
        {
            UCCreateCreditCard createcredit = new UCCreateCreditCard();
            AddUserControl(createcredit);
        }

        private void toolStripMenuPay_Click(object sender, EventArgs e)
        {
            UCPayByCredit paycredit = new UCPayByCredit();
            AddUserControl(paycredit);
        }

        private void toolStripMenuItemCreditRecharge_Click(object sender, EventArgs e)
        {
            UCCreditRecharge creditrecharge = new UCCreditRecharge();
            AddUserControl(creditrecharge);
        }
    }
}
