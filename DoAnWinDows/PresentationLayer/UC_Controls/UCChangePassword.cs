using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnWinDows.BusinessLayer.Models;
using DoAnWinDows.DataAccessLayer;
using DoAnWinDows.Helpers;
using DoAnWinDows.Utilities;

namespace DoAnWinDows
{
    public partial class UCChangePassword : UserControl
    {
        string captcha = "";
        ChangePassWordDAO changepass = new ChangePassWordDAO();
        CheckChangeAccount check = new CheckChangeAccount();
        public UCChangePassword()
        {
            InitializeComponent();
        }
        public void LoadList()
        {
            this.gvChangePassWord.DataSource = changepass.AccountCustomerList();
        }
        private void UCChangePassword_Load(object sender, EventArgs e)
        {
            captcha = Captcha.CaptchaRanDom();
            Captcha.DrawCaptcha(captcha, picCaptcha);
            LoadList();
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Notification", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                CustomerAccount account = new CustomerAccount(txtUserName.Text, txtOldPassWord.Text);
                if (check.validChange(account, captcha, txtCaptcha.Text))
                {
                    account.Password = txtNewPassWord.Text;
                    changepass.ChangePassword(account);
                    ClearText.ClearAll(this.Controls);
                }
                else
                {
                    ClearText.ClearAll(this.Controls);
                }
            }

            UCChangePassword_Load(sender, e);
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            ClearText.ClearAll(this.Controls);
        }
    }
}
