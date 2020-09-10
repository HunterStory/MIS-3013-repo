using System;
using System.Net.NetworkInformation;

namespace CoinToss
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Please pick Heads or Tails");
            string pick = Console.ReadLine();

            Random rnd = new Random();
            int number = rnd.Next(0, 2);

            if (number == 0)
                Console.WriteLine("The coin landed on Heads");
            else if (number == 1)
                Console.WriteLine("The coin landed on Tails");

            if (pick == "heads" && number == 0)
                Console.WriteLine("Your guess was right!");
            else if (pick == "tails" && number == 1)
                Console.WriteLine("Your guess was right!");
            else if (pick == "heads" && number == 1)
                Console.WriteLine("Your guess was incorrect");
            else if (pick == "tails" && number == 0)
                Console.WriteLine("Your guess was incorrect");


            
        }
    }
}
