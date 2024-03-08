using System.Diagnostics.CodeAnalysis;

namespace almaz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 777;
            int product = 1;
            int qaliq = 0;
            while (n != 0)
            {
                qaliq = n % 10;
                product *= qaliq;
                n = n - qaliq;
                n = n / 10;
            }
            Console.WriteLine(product);

        }
    }
}
