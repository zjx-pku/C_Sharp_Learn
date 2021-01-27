using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraEX01
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4;
            Console.WriteLine("请输入第一个数字");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入第二个数字");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入第三个数字");
            num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入第四个数字");
            num4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{num1} * {num2} * {num3} * {num4} = {num1 * num2 * num3 * num4}");
            Console.ReadKey();

        }
    }
}
