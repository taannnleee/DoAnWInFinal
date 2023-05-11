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

namespace DoAnWinDows
{
    public partial class UCChangePassword : UserControl
    {
        public CustomerAccount account;
        ChangePassWordDAO change = new ChangePassWordDAO();
        string captcha = "";
        ChangePassWordDAO changepassDAO = new ChangePassWordDAO();
        public UCChangePassword(CustomerAccount account)
        {
            InitializeComponent();
            this.account = account;
        }
        private void UCChangePassword_Load(object sender, EventArgs e)
        {
            captcha = changepassDAO.CaptchaRanDom();
            changepassDAO.DrawCaptchar(captcha, picCaptcha);
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {

            ChangePassWordDAO changepass = new ChangePassWordDAO();
            if (changepass.CheckCustomerAccount(captcha, txtCaptcha.Text) && (account.Password.Equals(txtOldPassWord.Text)))
            {
                account.Password = txtNewPassWord.Text;
                changepass.ChangePassword(account);
                UCChangePassword_Load(sender, e);
                ClearText.ClearAll(this.Controls);
            }
            else
            {
                MessageBox.Show("That bai");
                UCChangePassword_Load(sender, e);
                change.ClearCaptcha(txtCaptcha);
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            ClearText.ClearAll(this.Controls);
        }
    }
}
