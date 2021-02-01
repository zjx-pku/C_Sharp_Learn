using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch06Ex10
{
    class Program
    {
        delegate double ProcessDelegate(double param1, double param2);
        static double Multiply(double param1, double param2) => param1 * param2;
        static double Divide(double param1, double param2) => param1 / param2;

        static void Main(string[] args)
        {
            ProcessDelegate process;
            WriteLine($"Place input two number separated with a comma:");
            string input = ReadLine();
            int commaPos = input.IndexOf(",");
            double param1 = Convert.ToDouble(input.Substring(0, commaPos));
            double param2 = Convert.ToDouble(input.Substring(commaPos + 1, input.Length - commaPos - 1));

            WriteLine("Enter M to multiply or D to devide:");
            string Command = ReadLine();
            if (Command == "M")
            {
                process = new ProcessDelegate(Multiply);
            }
            else
            {
                process = new ProcessDelegate(Divide);
            }
            WriteLine($"{process(param1, param2)}");
            ReadKey();
        }
    }
}
