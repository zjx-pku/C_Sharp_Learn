using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Extra02
{
    class Program
    {
        delegate string Read();
        static void Main(string[] args)
        {
            Read myRead = new Read(ReadLine); //ReadLine不带括号
            WriteLine($"Plese input your string:");
            string input = myRead();
            WriteLine($"The string you input is \"{input}\".");
            ReadKey();
        }
    }
}
