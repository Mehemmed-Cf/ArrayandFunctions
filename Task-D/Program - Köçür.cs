namespace TaskD
{
    internal class Program
    {
         
        static void Main(string[] args)
        {


            string ReverseInteger(int num)

            {
                string str = Convert.ToString(num);
                string reverse = "";

                for (int i = str.Length - 1; i >= 0; i--)
                {

                   reverse = String.Concat(reverse, str[i]);

                }
                return reverse;
            }

            string str = ReverseInteger(1234);
            Console.WriteLine(str);
        }
    }
}