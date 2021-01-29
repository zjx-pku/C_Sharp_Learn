using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace Ch05Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] friendsName = { "Todd Anthony", "Kevin Holton", "Shane Laigle", null, "" };
            foreach(var friendName in friendsName)
            {
                switch (friendName)
                {
                    case string t when t.StartsWith("T"):
                        WriteLine("This friend's name starts with a 'T':" + $"{friendName} and is {t.Length - 1} letters long.");
                        break;
                    case string s when s.StartsWith("S"):
                        WriteLine("This friend's name starts with a 'S':" + $"{friendName} and is {s.Length - 1} letters long.");
                        break;
                    case string n when n.Length == 0:
                        WriteLine("There is a string in the array with no value.");
                        break;
                    case null:
                        WriteLine("There is a 'null' in the array.");
                        break;
                    case var x:
                        WriteLine("This is the var pattern of type:" + $"{x.GetType().Name}.");
                        break;
                    default:
                        break;
                }
            }

            int sum = 0, total = 0, counter = 0, intValue = 0;
            int?[] myIntArray = new int?[7] { 5, intValue, 9, 10, null, 2, 99 };
            foreach (var myInt in myIntArray)
            {
                switch(myInt)
                {
                    case 0:
                        WriteLine($"Integer number '{total}' has a default value of 0.");
                        total++;
                        break;
                    case int value:
                        sum += value;
                        counter++;
                        WriteLine($"Integer number '{total}' has a defalut value of {value}.");
                        total++;
                        break;
                    case null:
                        WriteLine($"Integer number '{total}' is null.");
                        total++;
                        break;
                    default:
                        break;
                }
            }
            WriteLine($"'{total}' total integers, {counter} integers with a" + $"value other than 0 or null have a sum value of {sum}.");
            ReadLine();
        }
    }
}
