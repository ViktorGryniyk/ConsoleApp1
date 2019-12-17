using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Class2
    {
        public int Min(int[] array)
        {
            int min = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (min > array[i])
                    min = array[i];
            }

            return min;
        }

        public int Max(int[] array)
        {
            int max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                    max = array[i];
            }

            return max;
        }
    }
}
