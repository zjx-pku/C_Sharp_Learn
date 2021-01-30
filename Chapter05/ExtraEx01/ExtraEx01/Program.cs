using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ExtraEx01
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInputStr = ReadLine();
            string outputString = "";
            foreach(char charInput in userInputStr)
            {
                outputString = charInput + outputString;
            }
            WriteLine(outputString);
            ReadKey();
        }
    }
}
