//第四章习题二存疑

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace ExtraEx01
{
    class Program
    {
        static void Main(string[] args)
        {
            bool numbersOK = false;
            double var1 = 0, var2 = 0;
            while(! numbersOK)
            {
                WriteLine("Plase input two number:");
                WriteLine("Now, input the first number:");
                var1 = ToDouble(ReadKey());
                WriteLine("Now, input the second number:");
                var2 = ToDouble(ReadKey());
                WriteLine($"The first number you input is {var1}, the second number you input is {vae2}.");

                if ((var1 > 10) ^ (var2 > 10))
                {
                    WriteLine("Both numbers you input is ")
                }
            }
        }
    }
}
/*
 * a ^ b 的算法为 (!a && b) || (a && !b)
 * 
 */