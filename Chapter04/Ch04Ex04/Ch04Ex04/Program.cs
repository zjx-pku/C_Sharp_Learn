
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace Ch04Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance, interestRate, targetBalance;
            WriteLine("What's your current balance?");
            balance = ToDouble(ReadLine());
            WriteLine("What's your current annual interest rate (in %)?");
            interestRate = ToDouble(ReadLine());
            WriteLine("What balance would you like to have?");
            targetBalance = ToDouble(ReadLine());

            int totalYears = 0;
            do
            {
                balance = balance * (1 + interestRate / 100);
                totalYears += 1;
            } while (balance < targetBalance);

            WriteLine($"In total {totalYears} year {(balance == 1 ? "" : "s")}" + $"you'll have a balance of {balance}.");
            ReadKey();
        }
    }
}
