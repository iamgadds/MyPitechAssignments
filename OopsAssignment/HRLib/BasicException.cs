using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
    public class BasicException : Exception
    {
        public BasicException(string msg) : base(msg)
        {

        }
    }
}
