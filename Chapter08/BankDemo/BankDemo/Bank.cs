using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDemo
{
    public class Bank
    {
        List<Account> accounts = new List<Account>();
        public Account OpenAccount(string id, string pwd, double money)
        {
            Account account = new Account(id, pwd, money);
            accounts.Add(account);
            return account;
        }
        public bool CloseAccount(Account account)
        {
            int idx = accounts.IndexOf((account));
            if (idx < 0)
                return false;
            accounts.Remove(account);
            return true;
        }
        public Account FindAccount(string id, string pwd)
        {
            foreach(Account account in accounts)
            {
                if(account.IsMatch(id,pwd))
                {
                    return account;
                }
            }
            return null;
        }
    }
}
