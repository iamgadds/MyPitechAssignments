using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasswordCheckLib;

namespace CheckPassword
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Check c1 = new Check();
                Console.WriteLine("Enter Your Password");
                string str1 = Console.ReadLine();
                c1.VerifyPassword(str1);
                Console.WriteLine("Your Password is appropriate");
            }
            catch (VerifyException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
