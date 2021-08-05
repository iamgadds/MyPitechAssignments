using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordCheckLib
{
    public class VerifyException : Exception
    {
        public VerifyException(string msg) : base(msg)
        {

        }
    }
}
