using System;
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
            int DailyHours = 0;
            int DH = DailyHours;
            Console.WriteLine("Welcome to Employee Wage Programme.");
            Random random = new Random();
            const int EMP_ABSENT = 0, EMP_PRESENT = 1, EMP_PARTTIME = 2;
            int empinput = random.Next(0,3);
            int WageperHour = 20;
            int DailyWage;
            switch(empinput)
            {
                case EMP_PRESENT:
                Console.WriteLine("Employee is Full-time Present");
                DH = 8;
                break;

                case EMP_PARTTIME:           
                Console.WriteLine("Employee is Part-time Present");
                DH = 4;
                break;

                case EMP_ABSENT:
                Console.WriteLine("Employee is Absent");
                DH = 0;
                break;

                default:
                    Console.WriteLine("something went wrong.....");
                break;
            }

            DailyWage = DH * WageperHour;
            Console.WriteLine("Daily Wage of Employee is {0}", DailyWage);
            Console.ReadLine();

        }
    }
}
