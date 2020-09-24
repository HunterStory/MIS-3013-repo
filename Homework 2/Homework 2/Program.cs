using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{   //Hunter Story
    class Program
    {
        static void Main(string[] args)
        {
            double acctGrade, markGrade, econGrade, misGrade, gpa;

            Console.WriteLine("What is your overall percentage grade in Accounting?");
            acctGrade = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade in Marketing?");
            markGrade = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade in Economics?");
            econGrade = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade in MIS?");
            misGrade = Convert.ToDouble(Console.ReadLine());


            string acct;
            int acctweight;
            if (acctGrade >= 90)
            {
                acct = "A";
                acctweight = 4;
            }
            else if (acctGrade >= 80)
            {
                acct = "B";
                acctweight = 3;
            }
            else if (acctGrade >= 70)
            {
                acct = "C";
                acctweight = 2;
            }
            else if (acctGrade >= 60)
            {
                acct = "D";
                acctweight = 1;
            }
            else
            {
                acct = "F";
                acctweight = 0;
            }









                Console.WriteLine("Your accounting grade is " + acct);

                gpa = acctweight;
                Console.WriteLine($"Your GPA is {gpa}");


                Console.ReadKey();
            }
        }
    }

