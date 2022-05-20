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
            Console.WriteLine("Welcome to Employee Wage Programme.");
            Random random = new Random();
            const int EMP_ABSENT = 0, EMP_PRESENT = 1, EMP_PARTTIME = 2;
            int empinput = random.Next(0,3);
            int WageperHour = 20;
            int DailyHours;
            int DailyWage;
            switch(empinput)
            {
                case EMP_PRESENT:
                Console.WriteLine("Employee is Full-time Present");
                DailyHours = 8;
                break;

                case EMP_PARTTIME:           
                Console.WriteLine("Employee is Part-time Present");
                DailyHours = 4;
                break;

                case EMP_ABSENT:
                Console.WriteLine("Employee is Absent");
                DailyHours = 0;
                break;

                default:
                    Console.WriteLine("something went wrong.....");
                break;
            }

            DailyWage = DailyHours * WageperHour;
            Console.WriteLine("Daily Wage of Employee is {0}", DailyWage);
            Console.ReadLine();

        }
    }
}
