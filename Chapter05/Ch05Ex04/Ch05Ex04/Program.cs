using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch05Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] friendsName = { "Todd Anthony", "Kevin Holton", "Shane Laigle" };
            int i;
            WriteLine($"Here are {friendsName.Length} of my friends:");
            for (i = 0; i < friendsName.Length; i++)
            {
                WriteLine(friendsName[i]);
            }
            ReadKey();
        }
    }
}
