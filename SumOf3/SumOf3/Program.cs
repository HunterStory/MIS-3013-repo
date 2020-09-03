using System;
using System.Dynamic;
using System.Globalization;

namespace SumOf3
{
    class Program
    {
        const double LUCKY_NUMBER = 7.777;
        private const string V = "N3";

        static void Main(string[] args)
        {

            Console.WriteLine("Enter your first number >>");
            string firstnumber = Console.ReadLine();
            double first = Convert.ToDouble(firstnumber);

            Console.WriteLine();
            Console.WriteLine("Enter your second number >>");
            string secondnumber = Console.ReadLine();
            double second = Convert.ToDouble(secondnumber);

            Console.WriteLine();
            Console.WriteLine("Enter your third number >>");
            string thirdnumber = Console.ReadLine();
            double third = Convert.ToDouble(thirdnumber);

            double sum = first + second + third;

            Console.WriteLine();
            Console.WriteLine("The sum of your three numbers is: " + sum.ToString("N3"));

            Console.WriteLine();
            Console.WriteLine("The sum of your three numbers multiplied by the lucky number is :" + sum * LUCKY_NUMBER);
        }
    }
}
