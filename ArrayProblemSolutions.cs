using System;
using System.Collections.Generic;

namespace _10_Array_Coding_Questions
{
    public class ArrayProblemSolutions
    {
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
            List <int> numbers = new();
            int size = array.Length;

            for(int i = 0; i < size; i++)
            {
                for(int k = i + 1; k < size; k++)
                {
                    if(array[i] == array[k])
                    {
                        numbers.Add(array[k]);
                    }
                }
            }
            return numbers.ToArray();
        }

        public static int LargestNumber(int[] array)
        {
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

        public static int SmallestNumber(int[] array)
        {
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }

        public static int PairCount(int[] array, int sum)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int k = i + 1; k < array.Length; k++)
                {
                    if ((array[i] + array[k]) == sum)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        public static int[] RemoveDuplicates(int[] array)
        {
            List<int> unique = new();
            for (int index = 0; index < array.Length; index++)
            {
                bool flag = false;
                int counter = 0;
                while (counter < index)
                {
                    if (array[index] == array[counter])
                    flag = true;
                    counter++;
                }
                if (flag == false) 
                {
                    unique.Add(array[index]);
                }
            }
            return unique.ToArray();
        }
        
        public static void Sort(int[] array)
        {
            for (int index = 0; index < array.Length; ++index)
            {
                int counter = index;
                
                while (counter > 0 && array[counter - 1] > array[counter])
                {
                    int buffer = array[counter];
                    array[counter] = array[counter - 1];
                    array[counter - 1] = buffer;
                    counter--;
                }
            }
        }

        public static bool Contains(int[] array, int value)
        {
            foreach (int element in array)
            {
                if (element == value)
                {
                    return true;
                }
            }
            return false;
        }
    }
}