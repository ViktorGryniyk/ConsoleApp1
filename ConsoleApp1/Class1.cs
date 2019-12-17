using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Class1
    {
        public int Method()
        {
            Console.Write("Input the number!");
            int n = Int32.Parse(Console.ReadLine());
            int sum = 1;
            while (n != 0)
            {
                sum *= n % 10;
                n = n / 10;
            }

            Console.WriteLine("Sum of the numbers is" + sum);
            return sum;
        }
    }
}
