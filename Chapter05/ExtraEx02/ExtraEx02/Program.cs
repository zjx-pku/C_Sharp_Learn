using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ExtraEx02
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInputStr = ReadLine();
            string outputStr;
            outputStr = userInputStr.Replace("no", "yes");
            WriteLine(outputStr);
            ReadKey();
        }
    }
}
