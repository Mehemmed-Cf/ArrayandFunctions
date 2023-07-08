using System;

namespace Task_A
{
    internal class Program
    {
        int[] PrintAboveLimit(int[] arr)
        {
            int limit = -4;

            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (limit < arr[i])
                {
                    count++;
                }
            }
    
            int[] limited = new int[count];

            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (limit < arr[i])
                {
                    limited[index] = arr[i];
                    index++;
                }
            }

            return limited;
        }

        static void Main(string[] args)
        {
            int[] numbers = { -7, -3, 2, -8, 5, -4 };

            int[] aboveLimit = PrintAboveLimit(numbers);

            foreach (int num in aboveLimit)
            {
                Console.WriteLine(num);
            }
        }
    }
}