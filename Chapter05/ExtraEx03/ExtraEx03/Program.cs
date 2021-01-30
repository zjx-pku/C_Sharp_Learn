using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ExtraEx03
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInputStr = ReadLine();
            string outputStr = "";
            char[] specator = { ' ' };
            string[] userInputStrSplit = userInputStr.Split(specator);
            foreach(string strSplit in userInputStrSplit)
            {
                outputStr = outputStr + "\"" + strSplit + "\" ";
            }
            WriteLine(outputStr);
            ReadKey();

        }
    }
}
