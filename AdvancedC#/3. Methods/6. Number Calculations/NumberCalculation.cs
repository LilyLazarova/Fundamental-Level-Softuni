//Write methods to calculate the minimum, maximum, average, sum and product of a given set of numbers. Overload the methods to work with numbers of type double and decimal.
//Note: Do not use LINQ.


using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace _6.Number_Calculations
{
    class NumberCalculation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integer numbers separated by space:");
            char[] separator = new char[] {' '};
            int[] numbers = Console.ReadLine().Split(separator,StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Console.WriteLine("Sum = {0}\n Min = {1}\n Max = {2}\n Avg = {3}\n Product = {4}",
                CalculateSum(numbers), CalculateMin(numbers), CalculateMax(numbers), CalculateAvg(numbers), CalculateProduct(numbers));

            Console.WriteLine("Enter decimal numbers separated by space:");
            decimal[] numbersDec = Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).ToArray();
            Console.WriteLine("Sum = {0}\n Min = {1}\n Max = {2}\n Avg = {3}\n Product = {4}",
                CalculateSum(numbersDec), CalculateMin(numbersDec), CalculateMax(numbersDec), CalculateAvg(numbersDec), CalculateProduct(numbersDec));
                 
         
        }

        // Product
         
        private static int CalculateProduct(int[] numbers)
        {
            int product = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                product *= numbers[i];
            }
            return product;
        }
        private static decimal CalculateProduct(decimal[] numbers)
        {
            decimal product = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                product *= numbers[i];
            }
            return product;
        }

        // Average

        private static double CalculateAvg(int[] numbers)
        {
            double average = 0;
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            average = (double)sum / numbers.Length;
            return average;
        }

        private static decimal CalculateAvg(decimal[] numbers)
        {
            decimal average = 0;
            decimal sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            average = (decimal)sum / numbers.Length;
            return average;
        }

        //Max Number

        private static int CalculateMax(int[] numbers)
        {
            int maxNumber = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                
                if (numbers[i]>maxNumber)
                {
                    maxNumber = numbers[i];
                }

            }
            return maxNumber;
        }

        private static decimal CalculateMax(decimal[] numbers)
        {
            decimal maxNumber = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > maxNumber)
                {
                    maxNumber = numbers[i];
                }
            }
            return maxNumber;
        }

        // Min Number

        private static int CalculateMin(int[] numbers)
        {
            int minNumber = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {

                if (numbers[i] < minNumber)
                {
                    minNumber = numbers[i];
                }

            }
            return minNumber;
        }

        private static decimal CalculateMin(decimal[] numbers)
        {
            decimal minNumber = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < minNumber)
                {
                    minNumber = numbers[i];
                }
            }
            return minNumber;
        }

        // Sum

        private static int CalculateSum(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        private static decimal CalculateSum(decimal[] numbers)
        {
            decimal sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
    }
}
