using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{   //Hunter Story
    class Program
    {
        static void Main(string[] args)
        {
            double acctGrade, markGrade, econGrade, misGrade;
            //string Aacct, B, C, D, F;

            Console.WriteLine("What is your overall percentage grade in Accounting?");
            acctGrade = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade in Marketing?");
            markGrade = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade in Economics?");
            econGrade = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade in MIS?");
            misGrade = Convert.ToDouble(Console.ReadLine());

            if (acctGrade >= 90)
                acctGrade = Console.WriteLine("Your Accounting grade is an A");





         //       Console.WriteLine("Your Accounting grade is an A");
         //   else if (acctGrade >= 80 && acctGrade < 90)
         //       Console.WriteLine("Your Accounting grade is a B");
         //   else if (acctGrade >= 70 && acctGrade < 80)
         //       Console.WriteLine("Your Accounting grade is a C");
         //   else if (acctGrade >=60 && acctGrade < 70)
         //       Console.WriteLine("Your Accounting grade is a D");
         //   else Console.WriteLine("Your Accounting grade is an F");

       
         //   if (markGrade >= 90)
         //       Console.WriteLine("Your Marketing grade is an A");
         //   else if (markGrade >= 80 && markGrade < 90)
         //       Console.WriteLine("Your Marketing grade is a B");
         //   else if (markGrade >= 70 && markGrade < 80)
         //       Console.WriteLine("Your Marketing grade is a C");
         //   else if (markGrade >= 60 && markGrade < 70)
         //       Console.WriteLine("Your Marketing grade is a D");
         //   else Console.WriteLine("Your Marketing grade is an F");


         //   if (econGrade >= 90)
         //       Console.WriteLine("Your Economics grade is an A");
         //   else if (econGrade >= 80 && econGrade < 90)
         //       Console.WriteLine("Your Economics grade is a B");
         //   else if (econGrade >= 70 && econGrade < 80)
         //       Console.WriteLine("Your Economics grade is a C");
         //   else if (econGrade >= 60 && econGrade < 70)
         //       Console.WriteLine("Your Economics grade is a D");
         //   else Console.WriteLine("Your Economics grade is an F");


         //  if (misGrade >= 90)
                //Console.WriteLine("Your MIS grade is an A");
         //   else if (misGrade >= 80 && misGrade < 90)
                //Console.WriteLine("Your MIS grade is a B");
         //   else if (misGrade >= 70 && misGrade < 80)
               // Console.WriteLine("Your MIS grade is a C");
         //   else if (misGrade >= 60 && misGrade < 70)
               // Console.WriteLine("Your MIS grade is a D");
         //   else Console.WriteLine("Your MIS grade is an F");

            Console.ReadKey();
        }
    }
}
