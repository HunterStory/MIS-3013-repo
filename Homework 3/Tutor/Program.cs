using System;

namespace Tutor
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd1 = new Random();
            int num1 = rnd1.Next(1, 51);

            Random rnd2 = new Random();
            int num2 = rnd2.Next(1, 51);

            Console.WriteLine($"What is {num1} + {num2}?");
            int guess = Convert.ToInt32(Console.ReadLine());

            int answer = num1 + num2;
            do
            {
                Console.WriteLine("Sorry, that is incorrect. Please try again");
                guess = Convert.ToInt32(Console.ReadLine());

            } while (answer != guess);

            Console.WriteLine("Congratulations, you got it correct");
            Console.ReadKey();
        }
    }
}
