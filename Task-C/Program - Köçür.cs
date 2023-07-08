using System;

namespace TaskC
{
    internal class Program
    {
        static int CountValueInArray(int[] ints, int value)
        {
            int count = 0;

            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] == value)
                {
                    count++;
                }
            }
            return count;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(CountValueInArray(new int[] { 1, 5, 8, 5, 3, 9 }, 5));
        }
    }
}