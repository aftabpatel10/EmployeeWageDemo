﻿using System;
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
            Console.WriteLine("Welcome to EmployeeWage Computation");
            
            const int EMP_RATE_PER_HR = 20;
            const int IS_PART_TIME = 1;
            const int IS_FULL_TIME = 2;
            const int NO_OF_WORKING_DAYS = 2;
            //int employeePresent = 1;
            int empWage = 0;
            int empHrs = 0;
            int totalEmpwage=0;
            for (int i = 0; i < NO_OF_WORKING_DAYS; i++)
            {
                Random r = new Random();
                int employeeInput = r.Next(0, 3);
                switch (employeeInput)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;

                    case IS_PART_TIME:
                        empHrs = 4;
                        break;

                    default:
                        empHrs = 0;
                        break;
                }
                empWage = EMP_RATE_PER_HR * empHrs;
                totalEmpwage += empWage;
                Console.WriteLine("Daily Employee Wage is:" + empWage);
                Console.ReadLine();
            }
            Console.WriteLine("Total emp Wage is:" +totalEmpwage);
        }
    }
}
