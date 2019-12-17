using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class7
    {
        private int[] randomArray;
        private int arrayLength;

        public void Method()
        {
            CreateArray();

            Array.Sort(randomArray);

            ViewArray();
            Console.ReadKey();

            var minValue = randomArray[0];
            var maxValue = randomArray[arrayLength - 1];

            var temp = minValue;
            randomArray[0] = maxValue;
            randomArray[arrayLength - 1] = temp;

            ViewArray();
        }

        private void CreateArray()
        {
            Random ranGen = new Random();
            Console.Write("Enter array size: ");
            arrayLength = int.Parse(Console.ReadLine());

            Console.Write("Enter min value: ");
            int randomMin = int.Parse(Console.ReadLine());

            Console.Write("Enter max value: ");
            int randomMax = int.Parse(Console.ReadLine());

            randomArray = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                randomArray[i] = ranGen.Next(randomMin, randomMax);
            }
        }

        private void ViewArray()
        {
            foreach (int item in randomArray)
                Console.Write($" {item}");

           Console.WriteLine();
        }
    }
}

            
           

       
