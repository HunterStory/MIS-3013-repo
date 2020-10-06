using System;

namespace TimeToBurnCalories
{
    class Program
    {
        static string name = "Hunter Story";
        static void Main(string[] args)
        {
            Console.WriteLine("How many calories would you like to burn?");
            double goal = Convert.ToDouble(Console.ReadLine());

            double calories = 0;
            int i = 1;
            do
            {
                calories = calories + 3.9;
                Console.WriteLine($"After {i++} minutes, you have burned {calories.ToString("N1")} calories");

            } while (calories < goal);

            Console.ReadKey();

        }
    }
}
