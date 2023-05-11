using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnWinDows.Utilities
{
    public class Calculation
    {
        public static string AddStrings(string num1, string num2)
        {
            int len1 = num1.Length;
            int len2 = num2.Length;
            int carry = 0;
            string result = "";
            for (int i = 1; i <= Math.Max(len1, len2); i++)
            {
                int digit1 = 0;
                int digit2 = 0;
                if (i <= len1)
                {
                    digit1 = num1[len1 - i] - '0';
                }
                if (i <= len2)
                {
                    digit2 = num2[len2 - i] - '0';
                }
                int sum = digit1 + digit2 + carry;

                if (sum >= 10)
                {
                    carry = 1;
                    sum -= 10;
                }
                else
                {
                    carry = 0;
                }
                result = sum.ToString() + result;
            }
            if (carry > 0)
            {
                result = carry.ToString() + result;
            }

            return result;
        }

        public static string SubtractStrings(string num1, string num2)
        {
            int len1 = num1.Length;
            int len2 = num2.Length;
            int borrow = 0;
            string result = "";
            for (int i = 1; i <= Math.Max(len1, len2); i++)
            {               
                int digit1 = 0;
                int digit2 = 0;
                if (i <= len1)
                {
                    digit1 = num1[len1 - i] - '0';
                }
                if (i <= len2)
                {
                    digit2 = num2[len2 - i] - '0';
                }

                int diff = digit1 - digit2 - borrow;
                if (diff < 0)
                {
                    borrow = 1;
                    diff += 10;
                }
                else
                {
                    borrow = 0;
                }
                result = diff.ToString() + result;
            }

            // Loại bỏ các chữ số 0 đầu tiên (nếu có)
            while (result.Length > 1 && result[0] == '0')
            {
                result = result.Substring(1);
            }
            return result;
        }
    }
}
