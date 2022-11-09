using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to EmployeeWage Conmputation");
            //UC1
            int employeePresent = 1;
            Random r = new Random();
            int empployeeIinput = r.Next(0, 2);

            if (employeePresent == employeeInput)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is Absent");
           
            Console.ReadLine();
        }
    }
}
