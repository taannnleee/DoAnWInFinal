using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DoAnWinDows.BusinessLayer.Models
{
    public class Customer
    {
        private string customerid;
        private string customername;
        private string identitycard;
        private string address;
        private string phonenumber;
        private string gender;
        private string email;

        public string Customerid { get => customerid; set => customerid = value; }
        public string Customername { get => customername; set => customername = value; }
        public string Identitycard { get => identitycard; set => identitycard = value; }
        public string Address { get => Address1; set => Address1 = value; }
        public string Address1 { get => address; set => address = value; }
        public string Phonenumber { get => phonenumber; set => phonenumber = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Email { get => email; set => email = value; }

        public Customer() { }

        public Customer(string customerid, string customername, string identitycard, string address, string phonenumber, string gender, string email)
        {
            Customerid = customerid;
            Customername = customername;
            Identitycard = identitycard;
            Address = address;
            Phonenumber = phonenumber;
            Gender = gender;
            Email = email;
        }
    }
}
