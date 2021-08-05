using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRLib;

namespace HRAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, addr;
            ConfirmEmployee ce1 = new ConfirmEmployee("","",6000,"");
            Trainee t1 = new Trainee("", "", 1, 10);

            char cont = 'n';

            do
            {
                Console.WriteLine("Enter Number: \n1) Display all Employees \n2) Insert Confirm Employee \n3) Insert Trainee \n4) Remove Employee by name \n5) Display Employee by name \n6)Exit");
                int num1 = Convert.ToInt32(Console.ReadLine());

                switch (num1)
                {
                    case 1:
                        Console.WriteLine("Name:" + ce1.EmployeeName + "\nAdress:" + ce1.EmployeeAddress + "\nBasic Salary:" + ce1.Basic + "\nDesignation:" + ce1.Designation + "\nNet Salary:" + ce1.CalculateSalary());
                        Console.WriteLine("Name:" + t1.EmployeeName + "\nAdress:" + t1.EmployeeAddress + "\nNo of Days:" + t1.NoOfDays + "\nRate:" + t1.RatePerDay + "\nNet Salary:" + t1.CalculateSalary());
                        break;
                    case 2:
                        Console.WriteLine("Enter Name:");
                        name = Console.ReadLine();
                        Console.WriteLine("Enter Address");
                        addr = Console.ReadLine();
                        Console.WriteLine("Enter Designation:");
                        string des = Console.ReadLine();
                        Console.WriteLine("Enter Basic Salary:");
                        double bas = Convert.ToDouble(Console.ReadLine());
                        
                        try
                        {
                            ce1 = new ConfirmEmployee(name, addr, bas, des);
                        }
                        catch(BasicException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter Name:");
                        name = Console.ReadLine();
                        Console.WriteLine("Enter Address");
                        addr = Console.ReadLine();
                        Console.WriteLine("Enter No of Days:");
                        int days = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Rate:");
                        double rate = Convert.ToDouble(Console.ReadLine());

                        t1 = new Trainee(name, addr, days, rate);
                        break;
                    default:
                        break;
                }

                Console.WriteLine("Continue y/n");
                cont = Convert.ToChar(Console.ReadLine());

            } while (cont == 'y');
            Console.ReadLine();
        }

    }
}
