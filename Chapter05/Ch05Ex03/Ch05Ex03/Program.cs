using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace Ch05Ex03
{
    enum origination : byte
    {
        north = 1,
        sourth = 2,
        east = 3,
        west = 4

    }
    struct route
    {
        public origination direction;
        public double distance;
    }
    class Program
    {
        static void Main(string[] args)
        {
            route myRoute;
            int myDirection = 1;
            double myDistance;
            WriteLine("1) north\n2) sourth\n3) east\n4) west");
            do
            {
                WriteLine("Select a direction:");
                myDirection = ToInt32(ReadLine());
            } while (myDirection < 1 || myDirection > 4);
            WriteLine("Input a distance:");
            myDistance = ToDouble(ReadLine());
            myRoute.distance = myDistance;
            myRoute.direction = (origination)myDirection;
            WriteLine($"myRoute specifies a direction of {myRoute.direction} " + $"and a distance of {myRoute.distance}.");
            ReadKey();
        }
    }
}
