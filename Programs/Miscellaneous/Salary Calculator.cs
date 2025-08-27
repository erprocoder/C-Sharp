using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator
{
    class SalaryCalculator
    {
        static void Main(string[] args)
        {
            float basic_salary, hra, da, pf, gross_salary, income_tax, deduction, net_salary;

            Console.Write("Enter the basic salary : ");
            basic_salary = float.Parse(Console.ReadLine());

            da = basic_salary * 15 / 100;

            hra = basic_salary * 10 / 100;

            pf = basic_salary * 10 / 100;

            income_tax = basic_salary * 10 / 100;
           
            deduction = pf + income_tax;

            gross_salary = basic_salary + da + hra;

            net_salary = gross_salary - deduction;

            Console.Write("\n\nBasic Salary : " + basic_salary);
            Console.Write("\n\nDearness Allowance : " + da);
            Console.Write("\n\nHouse Rent Allowance : " + hra);
            Console.Write("\n\nProvident Fund : " + pf);
            Console.Write("\n\nGross Salary : " + gross_salary);
            Console.Write("\n\nDeduction : " + deduction);
            Console.Write("\n\nNet Salary : " + net_salary);
            Console.ReadLine();
        }
    }
}