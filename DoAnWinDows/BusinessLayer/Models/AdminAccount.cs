using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DoAnWinDows.BusinessLayer.Models
{
    public  class AdminAccount
    {
        private string name;
        private string phone;
        private string password;
        private string identitycard;
        private string email;
        private string address;
        private DateTime dateofbirth;
        private string gender;
        private DateTime createdtime;
        private DateTime lastlogintime;

        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Password { get => password; set => password = value; }
        public string Identitycard { get => identitycard; set => identitycard = value; }
        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }
        public DateTime Dateofbirth { get => dateofbirth; set => dateofbirth = value; }
        public string Gender { get => gender; set => gender = value; }
        public DateTime Createdtime { get => createdtime; set => createdtime = value; }
        public DateTime Lastlogintime { get => lastlogintime; set => lastlogintime = value; }
   
        public AdminAccount(){}

        public AdminAccount(string name, string phone, string password, string identitycard, string email, string address, DateTime dateofbirth, string gender, DateTime createdtime, DateTime lastlogintime)
        {
            Name = name;
            Phone = phone;
            Password = password;
            Identitycard = identitycard;
            Email = email;
            Address = address;
            Dateofbirth = dateofbirth;
            Gender = gender;
            Createdtime = createdtime;
            Lastlogintime = lastlogintime;
        }

        public AdminAccount(string phone, string password)
        {
            Phone = phone;
            Password = password;
        }
    }
}
