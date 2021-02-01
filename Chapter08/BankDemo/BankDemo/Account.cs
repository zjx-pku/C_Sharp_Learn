using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDemo
{
    public class Account
    {
        double money;
        string id;
        string pwd;
        public Account(string id, string pwd, double money)
        {
            this.id = id;
            this.pwd = pwd;
            this.money = money;
        }
        public double GetMoney()
        {
            return this.money;
        }
        public void SetMoney(double val)
        {
            this.money = val;
        }
        public string GetId()
        {
            return this.id;
        }
        public void SetId(string id)
        {
            this.id = id;
        }
        public void SetPwd(string pwd)
        {
            this.pwd = pwd;
        }
        public bool SaveMoney(double money)
        {
            if (money < 0)
                return false;
            this.money += money;
            return true;
        }
        public bool WithdrawMoney(double money)
        {
            if (this.money < money)
                return false;
            this.money -= money;
            return true;
        }
        public bool IsMatch(string id, string pwd)
        {
            return this.id == id && this.pwd == pwd;
        }
    }
}
