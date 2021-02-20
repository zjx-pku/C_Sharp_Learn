using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch11Ex02
{
    public abstract class Animal
    {
        protected string name;                                  //字段
        public string Name                                      //属性
        {
            get { return name; }
            set { name = value; }
        }
        public Animal() => name = "The animal with no name";    //默认构造函数
        public Animal(string newName) => name = newName;        //带初始化参数的构造函数
        public void Feed() => WriteLine($"{name} has been fed.");
    }
}

