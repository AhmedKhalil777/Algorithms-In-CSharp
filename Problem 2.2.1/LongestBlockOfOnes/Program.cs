using System;
using System.Text.Json;

namespace LongestBlockOfOnes
{
    class Program
    {
        static void Main(string[] args)
        {
            // (pre condition) the input is A, a 0 , 1 array of length n
            // (post-condition) the output is the location of the A[k1...k2] of the longest block of ones and its length leng
            // begin

            Console.WriteLine("Please provide the length of list: ");
            // Default n = 10
            var n = int.Parse(Console.ReadLine() ?? "10");
            var arr = new int[n];
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine($"Enter the #{j+1} num: ");
                var v = int.Parse(Console.ReadLine() ?? "1");
                arr[j] = v is 1 or 0 ? v : 0;
            }
            int i = 0, pMax = 1, qMax = 0, lengMax = 0, pCurrent = 1, lengCurrent = 0;
            while (i < n)
            {
                if (arr[i] == 1)
                {
                    lengCurrent += 1;
                }
                else
                {
                    pCurrent = i + 1;
                    lengCurrent = 0;
                }

                if (lengMax< lengCurrent)
                {
                    pMax = pCurrent;
                    qMax = i +1;
                    lengMax = lengCurrent;
                }
                i++;
            }

            Console.WriteLine("Array = "+JsonSerializer.Serialize(arr.SubArray(pMax, qMax)));
            Console.WriteLine("length = "+ lengMax);
        }
        
        
    }
    public static class Extensions
    {
        public static T[] SubArray<T>(this T[] array, int offset, int last)
        {
            T[] result = new T[last-offset];
            Array.Copy(array, offset, result, 0, last - offset);
            return result;
        }
    }
}