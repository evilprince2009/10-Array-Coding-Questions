using System;

namespace _10_Array_Coding_Questions
{
    class Program
    {
        static void Main()
        {
            int[] given_array = { 1, 2, 3, 4, 87,5,32,65, 6, 7, 3, 7, 4, 1 };

            //int missing_num = ArrayProblemSolutions.GetMissingNumber(given_array);
            //Console.WriteLine("Missing number is {0}", missing_num);

            // int[] duplicates = ArrayProblemSolutions.GetDuplicateNumbers(given_array);
            // Console.WriteLine("Duplicate numbers are" + Environment.NewLine + "{0}", string.Join(" ", duplicates));

            int max_num = ArrayProblemSolutions.LargestNumber(given_array);
            int min_num = ArrayProblemSolutions.SmallestNumber(given_array);
            Console.WriteLine("Largest number is {0}", max_num);
            Console.WriteLine("Smallest number is {0}", min_num);
        }
    }
}
