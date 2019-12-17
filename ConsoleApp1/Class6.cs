using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class6
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


            while (true)
            {
                bool result = Output(randomArray);
                if (result)
                    break;
            }

            Console.ReadLine();
        }

        public bool Output(int[] array)
        {
            Console.WriteLine("Enter h or v for select output style");
            switch (Console.ReadLine())
            {
                case "h":
                    Console.WriteLine(String.Join(", ", array));
                    return true;
                case "v":
                    foreach (int value in array)
                        Console.WriteLine(value.ToString());
                    return true;

                default:
                    Console.WriteLine("Error: entered incorrect output style. Try again");
                    return false;
            }
        }
    }
}
