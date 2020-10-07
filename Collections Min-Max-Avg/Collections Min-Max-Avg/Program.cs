using System;
using System.Runtime.CompilerServices;

namespace Collections_Min_Max_Avg
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] grades = new double[4];
            //trying to create an array so I can use a foreach loop

            Console.WriteLine("What is your exam grade for Accounting?");
            double acct = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your exam grade for Marketing?");
            double mark = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your exam grade for Economics?");
            double econ = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your exam grade for MIS?");
            double mis = Convert.ToDouble(Console.ReadLine());

            string min;
            if (acct < mark)
            {
                min = Convert.ToString(acct);
            }
            else if (mark < econ)
            {
                min = Convert.ToString(mark);
            }
            else if (econ < mis)
            {
                min = Convert.ToString(econ);
            }
            else min = Convert.ToString(mis);
            Console.WriteLine($"Your minimum score is {min}");



            double average = (acct + mark + econ + mis) / 4;
            Console.WriteLine($"Your average score is {average}");

            Console.ReadKey();
        }
    }
}
