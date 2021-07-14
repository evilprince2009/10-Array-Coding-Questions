using System;

namespace _10_Array_Coding_Questions
{
    class Program
    {
        static void Main()
        {
            int[] a = { 1, 2, 4, 5, 6 };
            int miss = ArrayProblemSolutions.GetMissingNumber(a, 5);
            Console.WriteLine(miss);
        }
    }
}
