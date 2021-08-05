using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
    public class Trainee : Employee
    {
        private int noOfDays;

        public int NoOfDays
        {
            get { return noOfDays; }
            private set { noOfDays = value; }
        }

        private double ratePerDay;

        public double RatePerDay
        {
            get { return ratePerDay; }
            private set { ratePerDay = value; }
        }

        public override double CalculateSalary()
        {
            double NetSalary = RatePerDay * NoOfDays;
            return NetSalary;
        }

        public Trainee(string name, string addr, int days, double rate) : base(name, addr)
        {
            this.NoOfDays = days;
            this.RatePerDay = rate;
        }

    }
}
