using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; //直接访问静态类System.Console的WriteLine, ReadKey方法
using static System.Convert; //直接访问静态类System.Convert的Convert方法

namespace Ch04Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter an integer:");
            int myInt = ToInt32(ReadLine());
            bool isLessThan10 = myInt < 10;
            bool isBetween0And5 = (0 <= myInt) && (myInt <= 10);
            WriteLine($"integer is less than 10? {isLessThan10}");
            WriteLine($"integer is between 0 and 5? {isBetween0And5}");
            WriteLine($"Exactly is one of the above is true? {isBetween0And5 ^ isLessThan10}");
            ReadKey();
        }
    }
}
