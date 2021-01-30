
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch06Ex03
{
    class Program
    {
        static int SumVal(params int [] vals)
        {
            int sum = 0;
            foreach(int val in vals)
            {
                sum = sum + val;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int sum = SumVal(1, 3, 5, 7, 9);
            WriteLine($"{sum}");
            ReadKey();
        }
    }
}
