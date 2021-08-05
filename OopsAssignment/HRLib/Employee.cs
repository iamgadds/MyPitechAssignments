using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
    public abstract class Employee
    {
        private string employeeName;

        public string EmployeeName
        {
            get { return employeeName; }
            private set { employeeName = value; }
        }

        private string employeeAddress;

        public string EmployeeAddress
        {
            get { return employeeAddress; }
            private set { employeeAddress = value; }
        }

        public Employee(string name, string addr)
        {
            this.EmployeeName = name;
            this.EmployeeAddress = addr;
        }

        public abstract double CalculateSalary();

    }
}
