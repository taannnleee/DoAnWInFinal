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
    public partial class UC_Mortgage_BlackList : UserControl
    {
        public UC_Mortgage_BlackList()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtAccountNumber.Text == "" || txtAccountNumber.Text == null)
            {
                UC_Mortgage_BlackList_Load(sender, e);
            }
            else
            {
                gvInformation.DataSource = DAO_MortgageLoan.Search(txtAccountNumber.Text);
            }
        }

        private void UC_Mortgage_BlackList_Load(object sender, EventArgs e)
        {
            gvInformation.DataSource = DAO_MortgageLoan.Show_Mortgage_BlackList();
        }
    }
}
