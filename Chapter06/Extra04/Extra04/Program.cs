using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Extra04
{
    class Program
    {
        struct order
        {
            public string itemName;
            public int unitCount;
            public double unitCost;
            public double sumCost() => unitCost * unitCount;
            public string outputString()
            {
                WriteLine($"Order Information: {unitCount} {itemName} items at ${unitCost} each,\n"
                    + $"total cost ${sumCost()}");
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
