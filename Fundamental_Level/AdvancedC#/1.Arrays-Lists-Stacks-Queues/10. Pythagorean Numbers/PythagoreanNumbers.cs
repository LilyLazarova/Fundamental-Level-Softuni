//George likes math. Recently he discovered an interesting property of the Pythagorean Theorem: there are infinite number of triplets of integers a, b and c (a ≤ b), such that a2 + b2 = c2. Write a program to help George find all such triplets (called Pythagorean numbers) among a set of integer numbers.
//Input
//The input data should be read from the console. At the first line, we have a number n – the count of the input numbers. At the next n lines we have n different integers.
//The input data will always be valid and in the format described. There is no need to check it explicitly.
//Output
//Print at the console all Pythagorean equations a2 + b2 = c2 (a ≤ b), which can be formed by the input numbers. Each equation should be printed in the following format: "a*a + b*b = c*c". The order of the equations is not important. Beware of spaces: put spaces around the "+" and "=". In case of no Pythagorean numbers found, print "No".
//Constraints
//•	All input numbers will be unique integers in the range [0 … 999].
//•	The count of the input numbers will be in the range [1 ... 100].
//•	Time limit: 0.3 sec. Memory limit: 16 MB.
//Examples
//Input	Output		Input	Output		Input	Output
//8
//41
//5
//9
//12
//4
//13
//40
//3	5*5 + 12*12 = 13*13
//9*9 + 40*40 = 41*41
//3*3 + 4*4 = 5*5		5
//3
//12
//5
//0
//4	3*3 + 4*4 = 5*5
//0*0 + 3*3 = 3*3
//0*0 + 12*12 = 12*12
//0*0 + 5*5 = 5*5
//0*0 + 0*0 = 0*0
//0*0 + 4*4 = 4*4		3
//10
//20
//30	No


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Pythagorean_Numbers
{
    class PythagoreanNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number;
            int count = 0;
            List<int> sequence = new List<int>();

            if (n < 3)
            {
                Console.WriteLine("No");
                return;
            }

            while (true)
            {
                number = int.Parse(Console.ReadLine());
                sequence.Add(number*number);
                if (sequence.Count==n)
                {
                    break;
                }
            }

            for (int a = 0; a < sequence.Count; a++)
            {
                for (int b = 0; b < sequence.Count; b++)
                {
                    for (int c = 0; c < sequence.Count; c++)
                    {
                            if (sequence[a] + sequence[b] == sequence[c] && sequence[a]<=sequence[b])
                            {
                                Console.WriteLine("{0}*{0} + {1}*{1} = {2}*{2}", Math.Sqrt(sequence[a]), Math.Sqrt(sequence[b]), Math.Sqrt(sequence[c]));
                                count++;
                            }
                    }
                }
            } 
            if (count==0)
            {
                Console.WriteLine("No");
            }
 
        }
    }
}
