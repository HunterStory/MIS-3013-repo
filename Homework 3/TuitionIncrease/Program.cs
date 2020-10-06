using System;

namespace TuitionIncrease
{
    class Program
    {
        static void Main(string[] args)
        {
            double tuition = 12000;
            for (int i = 1; i < 8; i++)
            {
                tuition = tuition + (tuition * 0.05);
                Console.WriteLine($"Tuition after year {i} will be {tuition.ToString("C0")}");
            }

            Console.ReadKey();
        }
    }
}
