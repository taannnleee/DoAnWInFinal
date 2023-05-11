using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnWinDows.BusinessLayer.Models;
using DoAnWinDows.DataAccessObject;
using DoAnWinDows.Helpers;
using static Guna.UI2.WinForms.Helpers.GraphicsHelper;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Microsoft.VisualBasic.ApplicationServices;

namespace DoAnWinDows
{
    public partial class UCEmployeeManager : UserControl
    {
        EmployeeDao employeeDao = new EmployeeDao();
        public UCEmployeeManager()
        {
            InitializeComponent();
        }


        private void LoadDanhSach()
        {
            this.gvEmployee.DataSource = employeeDao.DanhSachQuanLy();
        }

        private void UCEmployeeManager_Load(object sender, EventArgs e)
        {
            LoadDanhSach();
        }

        string[] columnNames1 = { "UserName", "PassWord", "EmployeeID", "AccountType", "AccountStatus", "CreatedTime", "LastLoginTime", "EmployeeName", "IdentityCard", "Address", "PhoneNumber", "Gender", "Email", "Position", "Salary", "DateOfBirth" };

        private Dictionary<string, Control> PairData()
        {
            Dictionary<string, Control> textBoxMapping = new Dictionary<string, Control>
            {
                { "UserName", txtUserName},
                { "PassWord", txtPassWord},
                { "EmployeeID",txtEmployeeID },
                { "AccountType", cboAccountType},
                { "AccountStatus",txtAcountStatus },
                { "EmployeeName", txtEmployeeName},
                { "IdentityCard",txtIdentitycard },
                { "Address", txtAddress},
                { "PhoneNumber", txtPhoneNumber},
                { "Gender",cboGender },
                { "Email", txtEmail},
                { "Position", cboPosition},
                { "Salary", txtSalary},
                { "DateOfBirth",dtmDateOfBirth}
            };
            return textBoxMapping;
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            ClearText.ClearAll(this.Controls);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            EmployeeAccount empAcc = new EmployeeAccount(txtEmployeeID.Text, txtUserName.Text, txtPassWord.Text, txtEmployeeID.Text, cboAccountType.SelectedItem.ToString(), txtAcountStatus.Text, Time.GetCurrentTime(), Time.GetCurrentTime());
            Employee employee = new Employee(txtEmployeeID.Text, txtEmployeeName.Text, txtPhoneNumber.Text, txtIdentitycard.Text, txtEmail.Text, txtAddress.Text, dtmDateOfBirth.Value, cboGender.SelectedItem.ToString(), cboPosition.SelectedItem.ToString(), txtSalary.Text);
            if (employeeDao.IsIDExist(empAcc) == false)
            {
                if (employeeDao.Them(empAcc, employee))
                {
                    MessageBox.Show("Thanh Cong");
                }
                else
                {
                    MessageBox.Show("That Bai");
                }
            }
            else
            {
                MessageBox.Show("ID already exists");
            }

            LoadDanhSach();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            EmployeeAccount empAcc = new EmployeeAccount(txtEmployeeID.Text, txtUserName.Text, txtPassWord.Text, txtEmployeeID.Text, cboAccountType.SelectedItem.ToString(), txtAcountStatus.Text, Time.GetCurrentTime(), Time.GetCurrentTime());
            Employee employee = new Employee(txtEmployeeID.Text, txtEmployeeName.Text, txtPhoneNumber.Text, txtIdentitycard.Text, txtEmail.Text, txtAddress.Text, dtmDateOfBirth.Value, cboGender.SelectedItem.ToString(), cboPosition.SelectedItem.ToString(), txtSalary.Text);
            if (employeeDao.Xoa(empAcc, employee))
            {
                MessageBox.Show("Thanh Cong");
            }
            else
            {
                MessageBox.Show("That Bai");
            }
            LoadDanhSach();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            EmployeeAccount empAcc = new EmployeeAccount(txtEmployeeID.Text, txtUserName.Text, txtPassWord.Text, txtEmployeeID.Text, cboAccountType.SelectedItem.ToString(), txtAcountStatus.Text, Time.GetCurrentTime(), Time.GetCurrentTime());
            Employee employee = new Employee(txtEmployeeID.Text, txtEmployeeName.Text, txtPhoneNumber.Text, txtIdentitycard.Text, txtEmail.Text, txtAddress.Text, dtmDateOfBirth.Value, cboGender.SelectedItem.ToString(), cboPosition.SelectedItem.ToString(), txtSalary.Text);
            if (employeeDao.Sua(empAcc, employee))
            {
                MessageBox.Show("Thanh Cong");
            }
            else
            {
                MessageBox.Show("That Bai");
            }
            LoadDanhSach();
        }

        private void gvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            employeeDao.LoadRowInEmployeeTable(gvEmployee, columnNames1, PairData());
        }
    }
}
