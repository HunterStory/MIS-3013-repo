using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 101);
            Console.WriteLine(number);

            if (number % 3 == 0 && number % 5 == 0)
                Console.WriteLine("FizzBuzz");

            else if (number % 3 == 0)
                Console.WriteLine("Fizz");

            else if (number % 5 == 0)
                Console.WriteLine("Buzz");

            else

            {
                
            }

        }
    }
}
