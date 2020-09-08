using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 101);

            if (number % 3 == 0)
                Console.WriteLine("Fizz");

            else if (number % 5 == 0)
                Console.WriteLine("Buzz");

            else if (number % 3 == 0 && number % 5 == 0)
                Console.WriteLine("FizzBuzz");

            else Console.WriteLine(number);

            {
                
            }

        }
    }
}
