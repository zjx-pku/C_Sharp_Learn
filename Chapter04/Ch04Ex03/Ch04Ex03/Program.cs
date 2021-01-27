using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace Ch04Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            const string myName = "benjamin";
            const string niceName = "andrea";
            const string sillyName = "ploppy";

            string Name;
            WriteLine("What is your name?");
            Name = ReadLine();
            switch (Name.ToLower())
            {
                case myName:
                    WriteLine("You have the name as me!");
                    break;
                case niceName:
                    WriteLine("My, waht a nice name you have!");
                    break;
                case sillyName:
                    WriteLine("That\'s a very silly name.");
                    break;
            }
            WriteLine($"Hello {Name}!");
            ReadKey();
        }
    }
}
