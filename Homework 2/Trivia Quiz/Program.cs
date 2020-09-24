using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia_Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            string first, second, third, fourth, fifth;
            int firstAns, secondAns, thirdAns, fourthAns, fifthAns;

            Console.WriteLine("Answer the following 5 questions to see who is the smartest");

            Console.WriteLine();

            Console.WriteLine("The sky is blue. (T/F)");
            first = Console.ReadLine().ToLower();
            if (first == "t")
                firstAns = 1;
            else if (first == "f")
                firstAns = 0;
            else return;
            Console.WriteLine();

            Console.WriteLine("2 + 2 = 4. (T/F)");
            second = Console.ReadLine().ToLower();
            if (second == "t")
                secondAns = 1;
            else if (second == "f")
                secondAns = 0;
            else return;
            Console.WriteLine();

            Console.WriteLine("Grass is yellow. (T/F)");
            third = Console.ReadLine().ToLower();
            if (third == "f")
                thirdAns = 1;
            else if (third == "t")
                thirdAns = 0;
            else return;
            Console.WriteLine();

            Console.WriteLine("Earth is round. (T/F)");
            fourth = Console.ReadLine().ToLower();
            if (fourth == "t")
                fourthAns = 1;
            else if (fourth == "f")
                fourthAns = 0;
            else return;
            Console.WriteLine();

            Console.WriteLine("The sun is brown. (T/F)");
            fifth = Console.ReadLine().ToLower();
            if (fifth == "f")
                fifthAns = 1;
            else if (fifth == "t")
                fifthAns = 0;
            else return;
            Console.WriteLine();

            int ans;
            ans = firstAns + secondAns + thirdAns + fourthAns + fifthAns;

            double ansPercent;
            ansPercent = Convert.ToDouble(ans) / 5;


            Console.WriteLine($"Your score is {ans}/5 or {ansPercent.ToString("P0")}");

            Console.ReadKey();






        }
    }
}
