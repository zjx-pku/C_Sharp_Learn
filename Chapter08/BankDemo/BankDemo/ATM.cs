using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BankDemo
{
    public class ATM
    {
        Bank bank;
        public ATM(Bank bank)
        {
            this.bank = bank; ;
        }
        public void Transaction()
        {
            WriteLine("Plase input your card:");
            string id = ReadLine();
            WriteLine("Plase input your password:");
            string pwd = ReadLine();
            Account account = bank.FindAccount(id, pwd);
            if(account == null)
            {
                WriteLine("card invalid or password not correct");
                return;
            }

            WriteLine("1: display; 2: save; 3: withdraw");
            string op = ReadLine();
            if (op == "1")
            {
                WriteLine("balance: " + account.GetMoney());
            }
            else if (op == "2")
            {
                WriteLine("Plase input the amount of money you will save: ");
                double smoney = Convert.ToDouble(ReadLine());
                bool ok = account.SaveMoney(smoney);
                if (ok)
                    WriteLine("Success!");
                else
                    WriteLine("Error!");
                WriteLine("balance: " + account.GetMoney());
            }
            else if (op == "3")
            {
                WriteLine("Plase input the amount of money you will withdraw: ");
                double wmoney = Convert.ToDouble(ReadLine());
                bool ok = account.WithdrawMoney(wmoney);
                if (ok)
                    WriteLine("Success!");
                else
                    WriteLine("Error!");
                WriteLine("balance: " + account.GetMoney());
            }
        }
    }
}
