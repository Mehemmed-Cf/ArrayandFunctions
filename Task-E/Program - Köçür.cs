namespace TaskE
{
    internal class Program
    {
        static string[] NoRepetition(string[] strings)
        {
            strings.Distinct().ToArray();
            return strings;
        }

        static void Main(string[] args)
        {
            string[] strs = { "salam", "salam", "classroom", "test", "test" };

            Console.WriteLine(NoRepetition(strs));
        }
    }
}