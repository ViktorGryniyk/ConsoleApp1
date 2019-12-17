using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class3
    {
        public void Method()
        {
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());
            //int = 0;
            List<int> results = new List<int>();
            while (num != 0)
            {
                results.Add(num % 10);
                //Console.WriteLine("Digit:{0} ", num % 10);
                num = num / 10;
            }

            //results.Reverse();//второй вариант
            //Console.WriteLine($"Result: {String.Join(", ", results)}");

            Console.WriteLine();
            for (int i = results.Count-1; i >= 0; i--)
            {
                if(i != results.Count-1)
                    Console.Write(", ");

                Console.Write(results[i]);
            }

            Console.ReadKey();
        }
    }
}
