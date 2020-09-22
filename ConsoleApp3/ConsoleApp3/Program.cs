using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation 
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning.";

            Console.WriteLine(sentence);
            Console.WriteLine();

            Console.WriteLine("Choose a word to search for in the sentence above");
            string search = Console.ReadLine();

            Console.WriteLine("Choose a word to replace " + search + " with");
            string replace = Console.ReadLine();

           

            Console.ReadKey();
        }
    }
}
