using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Extra01
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                WriteLine("Two arguments required!");
                ReadKey();
            }
            else
            {
                string myString = args[0];
                int myInt = Convert.ToInt32(args[1]);
                WriteLine($"myString = {myString}, myInt = {myInt}");
                ReadKey();
            }
        }
    }
}
