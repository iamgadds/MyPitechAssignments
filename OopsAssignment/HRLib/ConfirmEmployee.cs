using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
    public class ConfirmEmployee : Employee
    {

        private double basic;

        public double Basic
        {
            get { return basic; }
            private set { basic = value; }
        }

        private string designation;

        public string Designation
        {
            get { return designation; }
            private set { designation = value; }
        }

        public override sealed double CalculateSalary()
        {
            double hra, conv, pf;
            if(Basic >= 50000)
            {
                hra = 0.3 * Basic;
                conv = 0.3 * Basic;
                pf = 0.1 * Basic;
            }
            else if (Basic >= 20000)
            {
                hra = 0.2 * Basic;
                conv = 0.2 * Basic;
                pf = 0.1 * Basic;
            }
            else
            {
                hra = 0.1 * Basic;
                conv = 0.1 * Basic;
                pf = 0.1 * Basic;
            }
            double NetSalary = Basic + hra + conv - pf;
            return NetSalary;
        }

        public ConfirmEmployee(string name, string addr, double bas, string des) : base(name, addr)
        {
            if(bas <= 5000)
            {
                throw new BasicException("Basic Salary should atleast be more than 5000");
            }
            this.Basic = bas;
            this.Designation = des;
        }

    }
}
