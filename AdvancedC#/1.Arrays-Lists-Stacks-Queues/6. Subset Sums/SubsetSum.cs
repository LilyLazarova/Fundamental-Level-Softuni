//Write a program that reads from the console a number N and an array of integers given on a single line. Your task is to find all subsets within the array which have a sum equal to N and print them on the console (the order of printing is not important). Find only the unique subsets by filtering out repeating numbers first. In case there aren't any subsets with the desired sum, print "No matching subsets." Examples:
//Input	Output
//11
//0 11 1 10 5 6 3 4 7 2	0 + 11 = 11
//11 = 11
//1 + 10 = 11
//0 + 1 + 10 = 11
//5 + 6 = 11
//0 + 5 + 6 = 11
//1 + 6 + 4 = 11
//0 + 1 + 6 + 4 = 11
//1 + 3 + 7 = 11
//0 + 1 + 3 + 7 = 11
//4 + 7 = 11
//0 + 7 + 4 = 11
//1 + 5 + 3 + 2 = 11
//0 + 1 + 5 + 3 + 2 = 11
//6 + 3 + 2 = 11
//0 + 6 + 3 + 2 = 11
//5 + 4 + 2 = 11
//0 + 5 + 4 + 2 = 11
//0
//1 2 3 4 5	No matching subsets.
//-2
//-5 4 92 0 928 1 -1 4	-5 + 4 + -1 = -2
//-5 + 4 + 0 + -1 = -2



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Subset_Sums
{
    class SubsetSum
    {

        static int N;
        static int sum = 0;
        static int[] numbers;
        static int i = 0;
        static List<int> subset = new List<int>();


        public static void Main()
        {

            N = 6;//int.Parse(Console.ReadLine());
            numbers = new int[] { 1, 2, 9, 0, 3, 5 };//Console.ReadLine().Split(' ').Select(int.Parse).ToList();


            MakeSubset(0);
        }


        private static void MakeSubset(int index)
        {
            
           while (index<numbers.Length)
	        {
               
               if (sum+numbers[index] < N)
                {
                    subset.Add(numbers[index]);
                    sum = subset.Sum();
                    MakeSubset(index + 1);
                }

                if (sum + numbers[i] == N)
                {
                    subset.Add(numbers[i]);
                    PrintSubset();
                    
                }
                //if (sum + numbers[i] > N )
                //{
                //    MakeSubset(index + 1);
                //}
                index++;
               
            }
            //if (subset.Count == numbers.Length - 1)
            //{
            //    return;
            //}
        }

        private static void PrintSubset()
        {
            Console.Write(string.Join(" + ", subset));
            Console.WriteLine(" = {0}", N);
        }
    }
}


            //else
            //{
            //    for (int j = 0; ; j++)
            //    {
            //        do
            //        {
            //            currentSum += numbers[j];
            //            subset.Add(numbers[j]);

            //        } while (currentSum<=N);
            //        Console.Write(string.Join("+",subset));
            //    }
            //for (currentSum = 0; currentSum <= N ; currentSum+=numbers[i])
            //{

            //}

            //do
            //{
            //    currentSum += numbers[i];
            //    subset.Add(numbers[i])
            //    Console.Write("{0} + ", numbers[i]);
            //    i++;

            //}
            //while (currentSum + numbers[i] <= N);
 

//===================================================================================

// Solution using bitmask


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//    class SubsetSum
//    {
//        static void Main(string[] args)
//        {
//            int sumInput = int.Parse(Console.ReadLine());
//            int[] sequence = Console.ReadLine().Split(' ').Select(int.Parse).Distinct().ToArray();
//            int sum = 0;
//            int counter = 0;        //count number of printing subsets' sums
//            int sumCounter =0;      //use the counter to ensure that if the input sum is 0 will not print sum even if it not add elements to the sum
//            List<int> subset = new List<int>();

           
//            double numberOfSubsets = Math.Pow(2, sequence.Length);
//            for (int i = 0; i < numberOfSubsets; i++)       //generate all the possible mask of the subset NumberOfSubsets
//            {
//                for (int j = 0; j < sequence.Length; j++)
//                {
//                    int mask = 1<<j;
//                    int result = i & mask;
                    
//                    if (result !=0)
//                    {
//                          sum += sequence[j];
//                          sumCounter++;
//                          subset.Add(sequence[j]);
//                    }
//                }
//                if (sum == sumInput && sumCounter>0 )
//                {
//                    Console.WriteLine("{0} = {1}", string.Join("+", subset), sumInput);
//                    counter++;
//                }
//                subset.Clear();
//                sum = 0;
//            } 
//            if (counter==0)
//            {
//                Console.WriteLine("No matching subsets.");
//            }
//    }
//}
