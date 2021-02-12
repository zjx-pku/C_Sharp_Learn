using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch09Ex01
{
    //public internal   可访问性
    //abstract sealed   继承和实例化
    //calss interface   类和接口
    public abstract class MyBase { }
    internal class MyClass : MyBase { }
    public interface IMyBaseInterface { }
    internal interface IMyBaseInterface2 { }
    internal interface IMyInterface : IMyBaseInterface, IMyBaseInterface2 { }
    internal sealed class MyConplexClass : MyClass, IMyInterface { }

    /// <summary>
    /// This class contains my program!
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            MyConplexClass myObj = new MyConplexClass();
            WriteLine(myObj.ToString());
            ReadKey();
        }
    }
}
