using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch10Ex02
{
    public class classA
    {
        private int state = -1;
        public int State => state;
        public class classB
        {
            public void setPrivateState(classA target, int newState)
            {
                target.state = newState;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            classA ClassA = new classA();
            WriteLine($"ClassA.State = {ClassA.State}");
            classA.classB ClassB = new classA.classB();
            ClassB.setPrivateState(ClassA, 999);
            WriteLine($"ClassA.State = {ClassA.State}");
            ReadKey();
        }
    }
}
