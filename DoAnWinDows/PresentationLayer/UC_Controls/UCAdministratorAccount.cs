using DoAnWinDows.BusinessLayer.Models;
using DoAnWinDows.DataAccessLayer;
using DoAnWinDows.DataAccessObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnWinDows.Helpers;
using DoAnWinDows.Utilities;

namespace DoAnWinDows
{
    public partial class UCAdministratorAccount : UserControl
    {
        AdministratorAccountDAO adminaccountDAO = new AdministratorAccountDAO();

        public UCAdministratorAccount()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            AdminAccount admin = new AdminAccount(txtName.Text, txtPhone.Text, txtPassWord.Text, txtIdentitycard.Text, txtEmail.Text, txtAddress.Text, dateTimeDateOfBirth.Value, comboBoxGender.SelectedItem.ToString(), Time.GetCurrentTime(), Time.GetCurrentTime());
            adminaccountDAO.Them(admin);
            LoadDanhSach();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            AdminAccount admin = new AdminAccount(txtName.Text, txtPhone.Text, txtPassWord.Text, txtIdentitycard.Text, txtEmail.Text, txtAddress.Text, dateTimeDateOfBirth.Value, comboBoxGender.SelectedItem.ToString(), Time.GetCurrentTime(), Time.GetCurrentTime());
            adminaccountDAO.Xoa(admin);
            LoadDanhSach();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            AdminAccount admin = new AdminAccount(txtName.Text, txtPhone.Text, txtPassWord.Text, txtIdentitycard.Text, txtEmail.Text, txtAddress.Text, dateTimeDateOfBirth.Value, comboBoxGender.SelectedItem.ToString(), Time.GetCurrentTime(), Time.GetCurrentTime());
            adminaccountDAO.Sua(admin);
            LoadDanhSach();
        }

        private void UCAdministratorAccount_Load(object sender, EventArgs e)
        {
            LoadDanhSach();
        }

        public void LoadDanhSach()
        {
            this.gvAdministratorAccount.DataSource = adminaccountDAO.DanhSachQuanLy();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {

            ClearText.ClearAll(this.Controls);
        }

        string[] columnNames1 = { "FullName", "Phone", "Pass", "IdentityCard", "Email", "Address_", "DateOfBirth", "Gender" };

        private Dictionary<string, Control> PairData()
        {
            Dictionary<string, Control> textBoxMapping = new Dictionary<string, Control>
            {
                { "FullName", txtName },
                { "Phone",  txtPhone  },
                { "Pass",txtPassWord},
                { "IdentityCard", txtIdentitycard },
                { "Email", txtEmail },
                { "Address_", txtAddress },
                { "DateOfBirth", dateTimeDateOfBirth },
                { "Gender", comboBoxGender }
            };
            return textBoxMapping;
        }

        private void gvAdministratorAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            adminaccountDAO.LoadRowInAdminAccountTable(gvAdministratorAccount, columnNames1, PairData());
        }
    }
}
