using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch09Ex03
{
    class MyClass
    {
        public int val;
    }
    struct MyStruct
    {
        public int val;
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            MyClass objectA = new MyClass();
            MyClass objectB = objectA;
            objectA.val = 10;
            objectB.val = 20;

            MyStruct structA = new MyStruct();
            MyStruct structB = new MyStruct();
            structA.val = 30;
            structB.val = 40;

            WriteLine($"objectA.val = {objectA.val}");
            WriteLine($"objectB.val = {objectB.val}");
            WriteLine($"structA.val = {structA.val}");
            WriteLine($"structB.val = {structB.val}");

            ReadKey();
        }
    }
}
