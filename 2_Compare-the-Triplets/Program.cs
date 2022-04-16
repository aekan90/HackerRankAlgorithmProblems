using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;

namespace _2_Compare_the_Triplets
{

    class Result
    {
        private static object list1;

        /*
         * Complete the 'compareTriplets' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY a
         *  2. INTEGER_ARRAY b
         *  
         *  Sample Input
         *  17 28 30  // alice inputs
         *  99 16 8   // bob inputs
         *  Sample Output
         *  2 1       // alice won
         *  
         */

        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            int AlicePoint = 0;
            int BobPoint = 0;
            List<int> result = new List<int>();

            int[] Alice = a.ToArray(); // [4][7][2]
            int[] Bob = b.ToArray();   // [3][5][9]

            for (int i = 0; i < Alice.Length; i++)
            {
                if (Alice[i] > Bob[i])
                {
                    AlicePoint++;
                }
                if (Alice[i] < Bob[i])
                {
                    BobPoint++;
                }
                if (Alice[i] == Bob[i])
                {
                    // nothing
                }
            }
            result.Add(AlicePoint);
            result.Add(BobPoint);

            return result;
        }

    }

    public class Program
    {
        static void Main(string[] args)
        {
            string fileName = "C:\\Users\\aekan\\source\\repos\\HackerRankAlgorithmProblems\\2_Compare-the-Triplets\\result.txt";

            // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable(fileName));

            StreamWriter textWriter = new StreamWriter(fileName);

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            List<int> result = Result.compareTriplets(a, b);

            textWriter.WriteLine(String.Join(" ", result));

            textWriter.Flush();
            textWriter.Close();
        }
    }
}

