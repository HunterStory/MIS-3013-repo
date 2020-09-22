using System;
using System.Net;

namespace Loops_P__.net_core_
{
    class Program
    {
        static void Main(string[] args)
        {
            int max, min, guess;

            Console.WriteLine("Pick a maximum value");
            max = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Pick a minimum value");
            min = Convert.ToInt32(Console.ReadLine());

            Random rnd = new Random();
            int number = rnd.Next(min, max+1);

            Console.WriteLine("Now guess a number between " + min + " and " + max + " until you get it correct");
            guess = Convert.ToInt32(Console.ReadLine());

            if (guess != number)
                do
                {
                    Console.WriteLine("That was incorrect, please guess again");
                    guess = Convert.ToInt32(Console.ReadLine());

                } while (guess != number);

            Console.WriteLine("That's correct, the number was " + number);

            Console.ReadKey();
        }
    }
}
