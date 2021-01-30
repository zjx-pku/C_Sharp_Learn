using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch06Ex02
{
    class Program
    {
        static int MaxValue(int[] intArray)
        {
            int maxValue = intArray[0];
            foreach(int num in intArray)
            {
                if (num > maxValue)
                {
                    maxValue = num;
                }
            }
            return maxValue;
        }
        static void Main(string[] args)
        {
            int[] intArray = { 1, 8, 3, 6, 2, 5, 9, 3, 0, 2 };
            int maxValue = MaxValue(intArray);
            WriteLine($"{maxValue}");
            ReadKey();
        }
    }
}
