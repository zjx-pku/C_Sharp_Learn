using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch06Ex09
{
    class Program
    {
        static int MaxValue(int [] intArray)
        {
            int maxValue = intArray[0];
            foreach(int value in intArray)
            {
                if (value > maxValue)
                    maxValue = value;
            }
            return maxValue;
        }
        static double MaxValue(double [] doubleArray)
        {
            double maxValue = doubleArray[0];
            foreach(double value in doubleArray)
            {
                if (value > maxValue)
                    maxValue = value;
            }
            return maxValue;
        }

        static void ShowDouble(ref int val)
        {
            val *= 2;
            WriteLine($"doubled val = {val}");
        }
        static void ShowDouble(int val)
        {
            val *= 2;
            WriteLine($"doubled val = {val}");
        }

        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5 };
            int intMaxValue = MaxValue(intArray);
            double doubleMaxValue = MaxValue(doubleArray);
            WriteLine($"intMaxValue = {intMaxValue}, doubleMaxValue = {doubleMaxValue}.");//5,5.5

            int val1 = 2, val2 = 2;
            ShowDouble(ref val1);           //4
            WriteLine($"val1 = {val1}.");   //4
            ShowDouble(val2);               //4
            WriteLine($"val2 = {val2}.");   //2
            ReadKey();

        }
    }
}
