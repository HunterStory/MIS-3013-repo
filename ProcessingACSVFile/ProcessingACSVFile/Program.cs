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

            for (int i = 1; i < lines.length; i++)
            {
                string line = lines[i];
                string[] pieces = line.Split(',');
                double sale = Convert.ToDouble(pieces[4]);
                string year = pieces[9];

            }
        }
    }
}
