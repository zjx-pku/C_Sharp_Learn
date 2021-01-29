using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch05Ex02
{
    enum orientation : byte
    {
        north = 1,
        sourth = 2,
        east = 3,
        west = 4
    }

    class Program
    {
        static void Main(string[] args)
        {
            byte directionByte;
            string directionString;
     
            orientation myDirection = orientation.north;
            WriteLine($"myorientation is {myDirection}");

            directionByte = (byte)myDirection;
            directionString = Convert.ToString(myDirection);
            WriteLine($"directionByte is {directionByte}");
            WriteLine($"directionString is {directionString}");

            ReadKey();
        }
    }
}
