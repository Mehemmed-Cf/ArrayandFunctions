namespace TaskB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int MultiplyValues(int[] integers, bool[] booleans)
            {
                int result = 1;
                int length = Math.Min(integers.Length, booleans.Length);

                for (int i = 0; i < length; i++)
                {
                    if (booleans[i] == true)
                    {
                        result *= integers[i];
                    }
                }
                return result;
            }

            Console.WriteLine(MultiplyValues(new[] { 6, 4, 7, 2 }, new[] { false, true, true, true }));
        }
    }
}