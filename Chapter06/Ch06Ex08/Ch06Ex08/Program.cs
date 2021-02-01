using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch06Ex08
{
    class Program
    {
        struct CustomerName
        {
            public string firstName, lastName;
            public string Name() => firstName + " " + lastName;
        }
        static void Main(string[] args)
        {
            CustomerName myCustomerName;
            myCustomerName.firstName = "John";
            myCustomerName.lastName = "Franklin";
            WriteLine($"myCustomer's name is {myCustomerName.Name()}");
            ReadKey();
        }
    }
}
