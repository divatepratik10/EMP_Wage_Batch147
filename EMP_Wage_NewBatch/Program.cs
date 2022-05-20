﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMP_Wage_NewBatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Programme.");
            Random random = new Random();
            const int EMP_PRESENT = 1;
            int empinput = random.Next(0,2);
            int WageperHour = 20;
            int DailyHours;
            int DailyWage;
            if (empinput == EMP_PRESENT)
            {
                Console.WriteLine("Employee is Present");
                DailyHours = 8;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                DailyHours = 0;
            }
            DailyWage = DailyHours * WageperHour;
            Console.WriteLine("Daily Wage of Employee is {0}", DailyWage);
            Console.ReadLine();

        }
    }
}
