using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch06Ex04
{
    class Program
    {
        static ref int ReturnString()
        {
            int[] array = { 2 };
            return ref array[0];
        }
        static void Main(string[] args)
        {
            int a = ReturnString();
            WriteLine($"{a}");
            ReadKey();
        }
    }
}
