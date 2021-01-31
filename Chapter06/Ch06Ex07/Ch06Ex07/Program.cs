using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch06Ex07
{
    class Program
    {
        static void Main(string[] args)
        {
            int myNumber = 5;
            WriteLine($"Main Function = {myNumber}.");
            DoubleInt(myNumber);
            ReadKey();

            void DoubleInt(int val)
            {
                val *= 2;
                WriteLine($"Local Function = {val}.");
            }

        }
    }
}
