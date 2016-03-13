//Write a program that reads N floating-point numbers from the console. Your task is to separate them in two sets, one containing only the round numbers (e.g. 1, 1.00, etc.) and the other containing the floating-point numbers with non-zero fraction. Print both arrays along with their minimum, maximum, sum and average (rounded to two decimal places). Examples:
//Input	Output
//1.2 -4 5.00 12211 93.003 4 2.2	[1.2, 93.003, 2.2] -> min: 1.2, max: 93.003, sum: 96.403, avg: 32.13
//[-4, 5, 12211, 4] - > min: -4, max: 12211, sum: 12216, avg: 3054.00


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Categorize_Numbers_and_Find_MinMaxAverage
{
    class MinMaxAvg
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a list of numbers, separated by space or comma:");
            List<double?> roundNumbers= new List<double?>();
            List<double?> floatNumbers = new List<double?>();
            //float[] numbers = Console.ReadLine().Split(',', ' ', ';').Select(float.Parse).ToArray();
            //using nullable variables to be possible to make a check with TryParse if no numbers are entered or they are letters/symbols

            //to check if input is in correct format
            double?[] numbers = Console.ReadLine().Split(' ', ',', ';','\n').Select(x =>
            {
                double value;
                return double.TryParse(x, out value)? value : (double?)null;
            }).ToArray();

            
            
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 1 == 0)
                {
                    roundNumbers.Add(numbers[i]);
                }
                else
                {
                    floatNumbers.Add(numbers[i]);
                }
            }

            double? maxRoundNumber=0;
            double? minRoundNumber=0;
            double? avgRoundNumber=0;
            double? maxFloatNumber=0;
            double? minFloatNumber=0;
            double? avgFloatNumber=0;

            try
            {
                maxRoundNumber = (double)roundNumbers.Max();
                minRoundNumber = (double)roundNumbers.Min();
                avgRoundNumber = (double)roundNumbers.Average();
                maxFloatNumber = (double)floatNumbers.Max();
                minFloatNumber = (double)floatNumbers.Min();
                avgFloatNumber = (double)floatNumbers.Average();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine();
                Console.WriteLine("Warning: Enter, some numbers to sort!",ex);
                Console.WriteLine();
            }
            Console.Write("[" + string.Join(" ",roundNumbers) +"]");
            Console.WriteLine("--> Min {0} ; Max {1} ; Avg {2:f2}",minRoundNumber,maxRoundNumber,avgRoundNumber);
            Console.Write("[" + string.Join(" ", floatNumbers) + "]");
            Console.WriteLine("--> Min {0} ; Max {1} ; Avg {2:f2}", minFloatNumber, maxFloatNumber, avgFloatNumber);
            Console.WriteLine();
        }
    }
}
