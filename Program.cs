using System;

namespace _10_Array_Coding_Questions
{
    class Program
    {
        static void Main()
        {
            int[] given_array = { 1, 2, 3, 4, 5, 6, 7, 8, 10 };

            int missing_num = ArrayProblemSolutions.GetMissingNumber(given_array);
            Console.WriteLine("Missing number is {0}", missing_num);
        }
    }
}
