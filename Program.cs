using System;

namespace _10_Array_Coding_Questions
{
    class Program
    {
        static void Main()
        {
            int[] given_array = { 1, 3, 2, 0, 4, 5, -1 , -3};

            //int missing_num = ArrayProblemSolutions.GetMissingNumber(given_array);
            //Console.WriteLine("Missing number is {0}", missing_num);

            // int[] duplicates = ArrayProblemSolutions.GetDuplicateNumbers(given_array);
            // Console.WriteLine("Duplicate numbers are" + Environment.NewLine + "{0}", string.Join(" ", duplicates));

            // int max_num = ArrayProblemSolutions.LargestNumber(given_array);
            // int min_num = ArrayProblemSolutions.SmallestNumber(given_array);
            //Console.WriteLine("Largest number is {0}", max_num);
            // Console.WriteLine("Smallest number is {0}", min_num);
            // int count = ArrayProblemSolutions.PairCount(given_array, 4);
            // Console.WriteLine(count);

            // int[] uniques = ArrayProblemSolutions.RemoveDuplicates(given_array);
            // Console.WriteLine("Unique numbers are" + Environment.NewLine + "{0}", string.Join(" ", uniques));

            ArrayProblemSolutions.Sort(given_array);
            Console.WriteLine("Sorted array is" + Environment.NewLine + "{0}", string.Join(" ", given_array));
            Console.WriteLine(ArrayProblemSolutions.Contains(given_array, 2));
        }
    }
}
