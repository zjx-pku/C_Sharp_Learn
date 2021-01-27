using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInteger;   //声明一个类型为int的变量myInteger
            string myString; //声明一个类型为string的变量myString

            myInteger = 17;
            myString = "\"myInteger\" is"; //给两个变量分配两个字面量

            Console.WriteLine($"{myString} {myInteger}"); //字符串插入
            Console.ReadKey();
        }
    }
}
