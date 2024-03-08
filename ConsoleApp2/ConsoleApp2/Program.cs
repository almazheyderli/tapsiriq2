namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            long fakt = 1;
            if (n < 0)
            {
                Console.WriteLine("menfi ededin faktoriyali yoxdur");
            }
            for (int i = 1; i <= n; i ++)
            {
                fakt *= i;
            
            }
            Console.WriteLine(fakt);
        }
    }
}
