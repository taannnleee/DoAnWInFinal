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

namespace DoAnWinDows
{
    public partial class FManager : Form
    {
        bool homeCollapsed;
        public FManager()
        {
            InitializeComponent();
        }

        public void AddUserControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panelManager.Controls.Clear();
            panelManager.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Hometimer.Start();
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

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            UCEmployeeManager employeeManager = new UCEmployeeManager();
            AddUserControl(employeeManager);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            UCCustomerAccount cusacc = new UCCustomerAccount();
            AddUserControl(cusacc);
        }
    }
}
