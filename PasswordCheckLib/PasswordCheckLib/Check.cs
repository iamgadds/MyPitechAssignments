using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordCheckLib
{
    public class Check
    {
        private void checkLength(string passwd)
        {
            if (passwd.Length < 6 || passwd.Length > 14)
            {
                throw new VerifyException("The password should be of minimum 6 characters"); 
            }
        }

        private void checkUpperCase(string passwd)
        {
            if (!passwd.Any(char.IsUpper))
            {
                throw new VerifyException("The password should contain atleast 1 upperCase");
            }
        }

        private void checkLowerCase(string passwd)
        {
            if (!passwd.Any(char.IsLower))
            {
                throw new VerifyException("The Password should contain atleast 1 LowerCase");
            }
        }

        private void checkSpace(string passwd)
        {
            if (passwd.Contains(" "))
            {
                throw new VerifyException("The password should not have a space in it");
            }
        }

        private void checkSpecialChar(string passwd)
        {
            string specialCh = @"%!@#$%^&*()?/>.<,:;'\|}]{[_~`+=-" + "\"";
            char[] specialChArray = specialCh.ToCharArray();
            int p = 0;
            foreach (char ch in specialChArray)
            {
                if (passwd.Contains(ch))
                {
                    p = 1;
                }
            }
            if (p == 0)
            {
                throw new VerifyException("The password should contain atleast 1 special character");
            }
        }

        public void VerifyPassword(string passwd)
        {
            checkLength(passwd);
            checkUpperCase(passwd);
            checkLowerCase(passwd);
            checkSpace(passwd);
            checkSpecialChar(passwd);
        }
    }
}
