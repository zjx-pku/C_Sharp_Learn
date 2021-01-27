using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace Ch04Ex05
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
            WriteLine("What balance would you like to have");
            targetBalance = ToDouble(ReadLine());

            int totalYears = 0;
            while(balance < targetBalance)
            {
                balance = balance * (1 + interestRate / 100);
                totalYears += 1;
            }
            if (totalYears == 0)
                WriteLine("To be honest, you really didn't need to use this caculator");
            else
                WriteLine($"In {totalYears} year {(totalYears == 1 ? "" : "s")} you will have a balance of {balance}.");
            ReadKey();
        }
    }
}
