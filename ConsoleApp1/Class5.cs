using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class5
    {
        public void Method()
        {
            Random ranGen = new Random();
            Console.Write("Enter array size: ");
            int arrayLength = int.Parse(Console.ReadLine());

            Console.Write("Enter min value: ");
            int randomMin = int.Parse(Console.ReadLine());

            Console.Write("Enter max value: ");
            int randomMax = int.Parse(Console.ReadLine());

            var randomArray = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                randomArray[i] = ranGen.Next(randomMin, randomMax);
            }

            foreach (var item in randomArray)
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadLine();
        }
    }
                        
}
