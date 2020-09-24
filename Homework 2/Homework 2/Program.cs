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


            string mark;
            int markWeight;
            if (markGrade >= 90)
            {
                mark = "A";
                markWeight = 4;
            }
            else if (markGrade >= 80)
            {  
                mark = "B";
                markWeight = 3;
            }
            else if (markGrade >= 70)
            {
                mark = "C";
                markWeight = 2;
            }
            else if (markGrade >= 60)
            {
                mark = "D";
                markWeight = 1;
            }
            else
            {
                mark = "F";
                markWeight = 0;
            }


            string econ;
            int econWeight;
            if (econGrade >= 90)
            {
                econ = "A";
                econWeight = 4;
            }
            else if (econGrade >= 80)
            {
                econ = "B";
                econWeight = 3;
            }
            else if (econGrade >= 70)
            {
                econ = "C";
                econWeight = 2;
            }
            else if (econGrade >= 60)
            {
                econ = "D";
                econWeight = 1;
            }
            else
            {
                econ = "F";
                econWeight = 0;
            }


            string mis;
            int misWeight;
            if (misGrade >= 90)
            {
                mis = "A";
                misWeight = 4;
            }
            else if (misGrade >= 80)
            {
                mis = "B";
                misWeight = 3;
            }
            else if (misGrade >= 70)
            {
                mis = "C";
                misWeight = 2;
            }
            else if (misGrade >= 60)
            {
                mis = "D";
                misWeight = 1;
            }
            else
            {
                mis = "F";
                misWeight = 0;
            }

            Console.WriteLine();
            Console.WriteLine("Your accounting grade is " + acct);
            Console.WriteLine($"Your Marketing grade is {mark}");
            Console.WriteLine($"Your Economics grade is {econ}");
            Console.WriteLine($"Your MIS grade is {mis}");

            Console.WriteLine();

            acctweight = acctweight * 3;
            markWeight = markWeight * 3;
            econWeight = econWeight * 3;
            misWeight = misWeight * 3;

  
            gpa = (acctweight + markWeight + econWeight + misWeight)/12;
            Console.WriteLine($"Your GPA is {gpa.ToString("N2")}");


                Console.ReadKey();
            }
        }
    }

