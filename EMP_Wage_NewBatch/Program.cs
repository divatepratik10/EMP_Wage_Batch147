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
            const int EMP_PRESENT = 1;
            int empinput = random.Next(0,2);

            if (empinput == EMP_PRESENT)
            {
                Console.WriteLine("Employee is Present");
            }
            else
                Console.WriteLine("Employee is Absent");

            Console.ReadLine();

        }
    }
}
