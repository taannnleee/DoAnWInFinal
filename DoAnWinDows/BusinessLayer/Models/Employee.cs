using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnWinDows.BusinessLayer.Models
{
    public class Employee
    {
        private string employeeid;
        private string employeename;
        private string phonenumber;
        private string identitycard;
        private string email;
        private string address;
        private DateTime dateofbirth;
        private string gender;
        private string position;
        private string salary;

        public string Employeeid { get => employeeid; set => employeeid = value; }
        public string Employeename { get => employeename; set => employeename = value; }
        public string Phonenumber { get => phonenumber; set => phonenumber = value; }
        public string Identitycard { get => identitycard; set => identitycard = value; }
        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }
        public DateTime Dateofbirth { get => dateofbirth; set => dateofbirth = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Position { get => position; set => position = value; }
        public string Salary { get => salary; set => salary = value; }
        
        public Employee(string employeeid,string employeename,string phonenumber,string identitycard,string email,string address,DateTime dateofbirth,string gender,string position,string salary)
        {
            Employeeid = employeeid;
            Employeename = employeename;
            Phonenumber = phonenumber;
            Identitycard = identitycard;
            Email = email;
            Address = address;
            Dateofbirth = dateofbirth;
            Gender = gender;
            Position = position;
            Salary = salary;
        }
    }
}
