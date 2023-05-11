using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnWinDows
{
    public partial class FPrintBill : Form
    {

        public string name,identitycard,job,phone,email,address,gender,transferAmount,finalbalance;
        private DateTime dateofbirth;
        public FPrintBill(string name, string phone, string identitycard, string job, string email, string address, DateTime dateofbirth, string gender, string finalbalance, string transferAmount)
        {
            InitializeComponent();
            lblDateCreate.Text = DateTime.Now.ToString("d/M/yyyy");
            this.name = name;
            this.identitycard = identitycard;
            this.job = job;
            this.phone = phone;
            this.email = email;
            this.address = address;
            this.gender = gender;
            this.transferAmount = transferAmount;
            this.finalbalance = finalbalance;
            this.dateofbirth = dateofbirth;
        }
        private void Print(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            pnlBill = pnl;
            getprintarea(pnl);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
            printPreviewDialog1.ShowDialog();
        }
        private Bitmap memoryimg;
        private void getprintarea(Panel pnl)
        {
            memoryimg = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memoryimg, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryimg, (pagearea.Width / 2) - (this.pnlBill.Width / 2), this.pnlBill.Location.Y);

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Print(pnlBill);
        }
        private void FPrintBill_Load(object sender, EventArgs e)
        {
            lblName.Text += this.name;
            lblIdentityCard.Text += this.identitycard;
            lblJob.Text+=this.job;
            lblPhone.Text+=this.phone;
            lblEmail.Text+=this.email;
            lblAddress.Text+=this.address;
            lblGender.Text+=this.gender;
            lblTransferAmount.Text += this.transferAmount;
            lblFinalBalance.Text += this.finalbalance;
            lblDateOfBirth.Text+=dateofbirth.ToString("d/M/yyyy");
        }
    }
}
