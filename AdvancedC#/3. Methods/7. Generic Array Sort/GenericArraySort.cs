//Write a method which takes an array of any type and sorts it. Use bubble sort or selection sort (your own implementation). You may re-use your code from a previous homework and modify it. 
//Use a generic method (read in Internet about generic methods in C#). Make sure that what you're trying to sort can be sorted – your method should work with numbers, strings, dates, etc., but not necessarily with custom classes like Student.
//Sample Code
 



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Generic_Array_Sort
{
    class GenericArraySort
    {
        static void Main(string[] args)
        {
            int[] numbers = {2, 5, 1, 9, 23, 5};
            string[] strings = { "apple", "mango", "cherry", "blueberry" };
            DateTime[] dates = 
            { new DateTime(1982,12,25) ,new DateTime(2006,07,16),new DateTime(2010,09,12), new DateTime(1982,08,29)
                               };
            Console.WriteLine("Original number array: {0}",string.Join(" ",numbers));
            Console.WriteLine("Sorted number array:{0}",string.Join(" ",SortArray(numbers)));
            Console.WriteLine("Original strings array: {0}",string.Join(" ",strings));
            Console.WriteLine("Sorted strings array: {0}",string.Join(" ",SortArray(strings)));
            Console.WriteLine("Original date/time array: {0}",string.Join(" ",dates));
            Console.WriteLine("Sorted date/time array: {0}",string.Join(" ",SortArray(dates)));

        }

        static T[] SortArray<T>(T[] sortedArray) where T:IComparable
        {
            int minPosition;
            
            for (int i = 0; i < sortedArray.Length-1; i++)
			{
                minPosition=i;
			     for (int j = i+1; j <sortedArray.Length; j++)
			    {
                    if ((sortedArray[j]).CompareTo(sortedArray[minPosition])<0)
                    {
                        minPosition = j;
                    }
			    }
                 if (i!=minPosition)
                 {
                     T temp=sortedArray[i];
                     sortedArray[i]=(sortedArray[minPosition]);
                     sortedArray[minPosition]=(temp);

                 }
			}
            return sortedArray;
            
            
        }
    }
}
