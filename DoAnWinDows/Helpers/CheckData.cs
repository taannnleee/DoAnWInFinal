using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DoAnWinDows.Helpers
{
    public class CheckData
    {
        public static bool CheckSdt(string temp)
        {
            long num;
            if (long.TryParse(temp, out num) && (temp.Length == 10))
            {
                return true;
            }
            return false;
        }

        public static bool CheckEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
                return false;
            try
            {
                Regex dinhdangemail = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
                return dinhdangemail.IsMatch(email.Trim());
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public static bool checkNull(string txt)
        {
            if (string.IsNullOrEmpty(txt) || (txt.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
