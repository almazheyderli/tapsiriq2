namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 7;
            int say = 0;
            for (int i = 1; i<= n; i++)
            {
                if (n % i == 0)
                {
                    say += 1;
                    i++;
                    
                }
                if (say > 2)
                {
                    Console.WriteLine("murekkebdir");

                }
                else
                {
                    Console.WriteLine("sadedir");
                }
            }
        }
    }
}
