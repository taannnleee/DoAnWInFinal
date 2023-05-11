using DoAnWinDows.DataAccessLayer;
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
    public partial class UC_Mortgage_ListOfLoanAccount : UserControl
    {
        public UC_Mortgage_ListOfLoanAccount()
        {
            InitializeComponent();
        }

        private void UC_Mortgage_ListOfLoanAccount_Load(object sender, EventArgs e)
        {
            gvInformation.DataSource = DAO_MortgageLoan.ShowMortgageLoanAccount();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtAccountNumber.Text == "")
            {
                UC_Mortgage_ListOfLoanAccount_Load(sender, e);
            }
            else
            {
                gvInformation.DataSource = DAO_MortgageLoan.Search(txtAccountNumber.Text);
            }
        }
    }
}
