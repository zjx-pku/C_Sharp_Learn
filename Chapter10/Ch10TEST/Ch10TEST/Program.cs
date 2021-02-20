using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch10TEST
{
    public class MyClass
    {
        #region Fields
        private int myInt;
        #endregion

        #region Constrator
        public MyClass() { myInt = 99; }
        #endregion

        #region Properties
        public int MyInt
        {
            get { return myInt; }
            set { myInt = value; }
        }
        #endregion

        #region Methods
        public void DoSomething()
        {
            //Do Something...
        }
        #endregion
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
