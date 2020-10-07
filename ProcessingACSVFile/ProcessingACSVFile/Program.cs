using System;
using System.IO;

namespace ProcessingACSVFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"sales_data_sample (1).csv";

            string[] lines = File.ReadAllLines(filepath);

            double sum = 0;
            double sumfor2003 = 0;
            double sumfor2004 = 0;
            double sumfor2005 = 0;
            double jan2003 = 0;
            double feb2003 = 0;
            double mar2003 = 0;
            double apr2003 = 0;
            double may2003 = 0;
            double jun2003 = 0;
            double jul2003 = 0;
            double aug2003 = 0;
            double sep2003 = 0;
            double oct2003 = 0;
            double nov2003 = 0;
            double dec2003 = 0;
            double jan2004 = 0;
            double feb2004 = 0;
            double mar2004 = 0;
            double apr2004 = 0;
            double may2004 = 0;
            double jun2004 = 0;
            double jul2004 = 0;
            double aug2004 = 0;
            double sep2004 = 0;
            double oct2004 = 0;
            double nov2004 = 0;
            double dec2004 = 0;
            double jan2005 = 0;
            double feb2005 = 0;
            double mar2005 = 0;
            double apr2005 = 0;
            double may2005 = 0;
            double jun2005 = 0;
            double jul2005 = 0;
            double aug2005 = 0;
            double sep2005 = 0;
            double oct2005 = 0;
            double nov2005 = 0;
            double dec2005 = 0;




            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] pieces = line.Split(',');
                double sale = Convert.ToDouble(pieces[4]);
                string year = pieces[9];
                string month = pieces[8];
                if (pieces[6].Trim().ToLower() == "shipped")
                {
                    if (year == "2003")
                    {
                        sumfor2003 += sale;
                        if (month == "1")
                        {
                            jan2003 += sale;
                        }
                        else if (month == "2")
                        {
                            feb2003 += sale;
                        }
                        else if (month == "3")
                        {
                            mar2003 += sale;
                        }
                        else if (month == "4")
                        {
                            apr2003 += sale;
                        }
                        else if (month == "5")
                        {
                            may2003 += sale;
                        }
                        else if (month == "6")
                        {
                            jun2003 += sale;
                        }
                        else if (month == "7")
                        {
                            jul2003 += sale;
                        }
                        else if (month == "8")
                        {
                            aug2003 += sale;
                        }
                        else if (month == "9")
                        {
                            sep2003 += sale;
                        }
                        else if (month == "10")
                        {
                            oct2003 += sale;
                        }
                        else if (month == "11")
                        {
                            nov2003 += sale;
                        }
                        else
                        {
                            dec2003 += sale;
                        }
                    }
                    else if (year == "2004")
                    {
                        sumfor2004 += sale;
                        if (month == "1")
                        {
                            jan2004 += sale;
                        }
                        else if (month == "2")
                        {
                            feb2004 += sale;
                        }
                        else if (month == "3")
                        {
                            mar2004 += sale;
                        }
                        else if (month == "4")
                        {
                            apr2004 += sale;
                        }
                        else if (month == "5")
                        {
                            may2004 += sale;
                        }
                        else if (month == "6")
                        {
                            jun2004 += sale;
                        }
                        else if (month == "7")
                        {
                            jul2004 += sale;
                        }
                        else if (month == "8")
                        {
                            aug2004 += sale;
                        }
                        else if (month == "9")
                        {
                            sep2004 += sale;
                        }
                        else if (month == "10")
                        {
                            oct2004 += sale;
                        }
                        else if (month == "11")
                        {
                            nov2004 += sale;
                        }
                        else
                        {
                            dec2004 += sale;
                        }
                    }
                    else
                    {
                        sumfor2005 += sale;
                        if (month == "1")
                        {
                            jan2005 += sale;
                        }
                        else if (month == "2")
                        {
                            feb2005 += sale;
                        }
                        else if (month == "3")
                        {
                            mar2005 += sale;
                        }
                        else if (month == "4")
                        {
                            apr2005 += sale;
                        }
                        else if (month == "5")
                        {
                            may2005 += sale;
                        }
                        else if (month == "6")
                        {
                            jun2005 += sale;
                        }
                        else if (month == "7")
                        {
                            jul2005 += sale;
                        }
                        else if (month == "8")
                        {
                            aug2005 += sale;
                        }
                        else if (month == "9")
                        {
                            sep2005 += sale;
                        }
                        else if (month == "10")
                        {
                            oct2005 += sale;
                        }
                        else if (month == "11")
                        {
                            nov2005 += sale;
                        }
                        else
                        {
                            dec2005 += sale;
                        }
                    }

                    sum += sale;
                }

            }

            Console.WriteLine($"The total sales for shipped items in 2003 is {sumfor2003.ToString("C")}!");
                Console.WriteLine($"The total sales for shipped items in January 2003 is {jan2003.ToString("C")}!");
                Console.WriteLine($"The total sales for shipped items in Febuary 2003 is {feb2003.ToString("C")}!");
                Console.WriteLine($"The total sales for shipped items in March 2003 is {mar2003.ToString("C")}!");
                Console.WriteLine($"The total sales for shipped items in April 2003 is {apr2003.ToString("C")}!");
                Console.WriteLine($"The total sales for shipped items in May 2003 is {may2003.ToString("C")}!");
                Console.WriteLine($"The total sales for shipped items in June 2003 is {jun2003.ToString("C")}!");
                Console.WriteLine($"The total sales for shipped items in July 2003 is {jul2003.ToString("C")}!");
                Console.WriteLine($"The total sales for shipped items in August 2003 is {aug2003.ToString("C")}!");
                Console.WriteLine($"The total sales for shipped items in September 2003 is {sep2003.ToString("C")}!");
                Console.WriteLine($"The total sales for shipped items in Ocotber 2003 is {oct2003.ToString("C")}!");
                Console.WriteLine($"The total sales for shipped items in November 2003 is {nov2003.ToString("C")}!");
                Console.WriteLine($"The total sales for shipped items in December 2003 is {dec2003.ToString("C")}!");
            Console.WriteLine($"The total sales for shipped items in 2004 is {sumfor2004.ToString("C")}!");
                Console.WriteLine($"The total sales for shipped items in January 2004 is {jan2004.ToString("C")}!");
                Console.WriteLine($"The total sales for shipped items in Febuary 2004 is {feb2004.ToString("C")}!");
                Console.WriteLine($"The total sales for shipped items in March 2004 is {mar2004.ToString("C")}!");
                Console.WriteLine($"The total sales for shipped items in April 2004 is {apr2004.ToString("C")}!");
                Console.WriteLine($"The total sales for shipped items in May 2004 is {may2004.ToString("C")}!");
                Console.WriteLine($"The total sales for shipped items in June 2004 is {jun2004.ToString("C")}!");
                Console.WriteLine($"The total sales for shipped items in July 2004 is {jul2004.ToString("C")}!");
                Console.WriteLine($"The total sales for shipped items in August 2004 is {aug2004.ToString("C")}!");
                Console.WriteLine($"The total sales for shipped items in September 2004 is {sep2004.ToString("C")}!");
                Console.WriteLine($"The total sales for shipped items in Ocotber 2004 is {oct2004.ToString("C")}!");
                Console.WriteLine($"The total sales for shipped items in November 2004 is {nov2004.ToString("C")}!");
                Console.WriteLine($"The total sales for shipped items in December 2004 is {dec2004.ToString("C")}!");
            Console.WriteLine($"The total sales for shipped items in 2005 is {sumfor2005.ToString("C")}!");
                Console.WriteLine($"The total sales for shipped items in January 2005 is {jan2005.ToString("C")}!");
                Console.WriteLine($"The total sales for shipped items in Febuary 2005 is {feb2005.ToString("C")}!");
                Console.WriteLine($"The total sales for shipped items in March 2005 is {mar2005.ToString("C")}!");
                Console.WriteLine($"The total sales for shipped items in April 2005 is {apr2005.ToString("C")}!");
                Console.WriteLine($"The total sales for shipped items in May 2005 is {may2005.ToString("C")}!");
                Console.WriteLine($"The total sales for shipped items in June 2005 is {jun2005.ToString("C")}!");
                Console.WriteLine($"The total sales for shipped items in July 2005 is {jul2005.ToString("C")}!");
                Console.WriteLine($"The total sales for shipped items in August 2005 is {aug2005.ToString("C")}!");
                Console.WriteLine($"The total sales for shipped items in September 2005 is {sep2005.ToString("C")}!");
                Console.WriteLine($"The total sales for shipped items in Ocotber 2005 is {oct2005.ToString("C")}!");
                Console.WriteLine($"The total sales for shipped items in November 2005 is {nov2005.ToString("C")}!");
                Console.WriteLine($"The total sales for shipped items in December 2005 is {dec2005.ToString("C")}!");

            Console.WriteLine($"Total sales of shipped orders is {sum.ToString("C2")}.");

            Console.ReadKey();
        }
    }
}
