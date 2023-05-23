using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestDemoExam4.Validation
{
    class ValidationClass
    {
        public bool CheckStringData(string str, int minlength, int maxLength)
        {
            if(str.Length >= minlength && str.Length <= maxLength)
            {
                return true;
            }
            return false;
        }

        public bool CheckIntData(string str, int minVlaue)
        {
            try
            {
                int number = Int32.Parse(str);
                if (number >= minVlaue)
                {
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public bool CheckDate(string str)
        {
            try
            {
                DateTime date = DateTime.Parse(str);
                return true;
            }
            catch { return false; }
        }

        public bool CheckEmail(string str)
        {
            if(str.Length >= 5 && str.Length <= 250)
            {
                string pattern = "^[a-z0-9-_.]+@[a-z]+\\.[a-z]+";
                Match isMatch = Regex.Match(str, pattern, RegexOptions.IgnoreCase);
                return isMatch.Success;
            }
            return false;
        }

        public bool CheckPassword(string str)
        {
            string pattern = "(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&*])[0-9a-zA-Z!@#$%^&*]{5,50}";
            Match isMatch = Regex.Match(str, pattern);
            return isMatch.Success;
        }

        public bool CheckPhone(string str)
        {
            string pattern = "^8\\d{10}";
            Match isMatch = Regex.Match(str, pattern, RegexOptions.IgnoreCase);
            return isMatch.Success;
        }
    }
}
