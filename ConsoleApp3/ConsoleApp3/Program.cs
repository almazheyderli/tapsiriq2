namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 121;
            int k;
            int sum = 0;
            while (n > 0)
            {
                k = n % 10;
                sum = sum * 10 + k;
                n = n / 10;
            }
           if (sum != n)
            {
                Console.WriteLine("polindrom deyil");
            }
            else
            {
                Console.WriteLine("polindromdur");
            }
        }
    }
}
