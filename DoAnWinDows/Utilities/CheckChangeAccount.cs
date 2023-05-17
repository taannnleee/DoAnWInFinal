using DoAnWinDows.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnWinDows.Utilities;
using DoAnWinDows.BusinessLayer.Models;
using System.Diagnostics.Eventing.Reader;

namespace DoAnWinDows.Utilities
{
    public class CheckChangeAccount
    {
        ChangePassWordDAO checkAccount = new ChangePassWordDAO();
        public bool validChange(CustomerAccount account, string captcha, string displaycaptcha)
        {
            if ((checkAccount.IsCvvtExists(account)) && checkAccount.CheckCustomerAccount(captcha, displaycaptcha))
            {
                MessageBox.Show("Success");
                return true;

            }
            else
            {
                if (checkAccount.IsCvvtExists(account) == false)
                {
                    MessageBox.Show("incorrect account");
                }
                if (checkAccount.CheckCustomerAccount(captcha, displaycaptcha) == false)
                {
                    MessageBox.Show("Incorrect captcha");
                }
                MessageBox.Show("Fail");
                return false;

            }
        }
    }
}
