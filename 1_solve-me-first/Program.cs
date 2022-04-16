using System;

namespace _1_solve_me_first
{
    internal class Program
    {

        public static int SolveMeFirst(int a, int b)
        {
            // Hint: Type return a+b; below  
            if ((1 < a && a < 100) && (1 < b && b < 100))
            {
                return a + b;
            }
            return -1;
        }

        public static void Main(String[] args)
        {
            int val1 = Convert.ToInt32(Console.ReadLine());
            int val2 = Convert.ToInt32(Console.ReadLine());
            int sum = SolveMeFirst(val1, val2);
            Console.WriteLine(sum);
        }
    }
}