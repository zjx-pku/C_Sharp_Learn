using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch06Ex05
{
    class Program
    {
        static int MaxValue(int [] array, out int maxIndex)
        {
            int maxValue = array[0];
            maxIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                    maxIndex = i;
                }
            }
            return maxValue;
        }
        static void Main(string[] args)
        {
            int[] array = { 1, 3, 5, 6, 9 };
            WriteLine($"The maxValue is {MaxValue(array, out int maxIndex)}.");
            WriteLine($"The index of the maxValue(first occurrence) is {maxIndex}.");
            ReadLine();
        }
    }
}
