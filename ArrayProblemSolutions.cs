using System;
using System.Collections.Generic;

namespace _10_Array_Coding_Questions
{
    public class ArrayProblemSolutions
    {
        // Finding the missing number in a given integer array
        public static int GetMissingNumber(int[] input_array)
        {
            int array_length = input_array.Length;
            int total = (array_length + 1) * (array_length + 2) / 2;
            for (int i = 0; i < array_length; i++)
            {
                total -= input_array[i];
            }
            return total;
        }
        public static int[] GetDuplicateNumbers(int[] array)
        {
            List<int> numbers = new();
            int size = array.Length;

            for (int i = 0; i < size; i++)
            {
                int element = Math.Abs(array[i]);
                if (array[element] >= 0)
                {
                    array[element] = -array[element];
                }
                else
                {
                    numbers.Add(element);
                }
            }
            return numbers.ToArray();
        }

        public static int LargestNumber(int[] array){
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }
    }
}
