using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Extra03
{
    class Program
    {
        struct order
        {
            public string itemName;
            public int unitCount;
            public double unitCost;
            public double sumCost() => unitCost * unitCount; // struct中定义的变量相当于在struct中的全局变量，在函数中也可以访问
        }
        static void Main(string[] args)
        {

        }
    }
}
