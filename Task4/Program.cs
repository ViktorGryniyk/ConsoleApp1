using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Enter stepen: ");
            int n = int.Parse(Console.ReadLine());
            int num_n = 1;
            for (int i = 0; i < n; i++)
            {
                num_n*= num;
            }
            Console.WriteLine("{0}^{1}={2}", num, n, num_n);
            Console.ReadKey();
        }
    }
}
