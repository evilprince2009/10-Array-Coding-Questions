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
    }
}
