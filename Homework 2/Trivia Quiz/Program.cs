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
            int firstAns;

            Console.WriteLine("Answer the following 5 questions to see who is the smartest");

            Console.WriteLine("The sky is blue. (T/F)");
            firstAns = Convert.ToInt32(Console.ReadLine());
            if (firstAns == "T")
                firstAns = 1;
            else firstAns = 0;

            Console.WriteLine("2 + 2 = 4. (T/F)");
            Console.WriteLine("Grass is yellow. (T/F)");
            Console.WriteLine("Earth is round. (T/F)");
            Console.WriteLine("The sun is yellow. (T/F)");
        }
    }
}
