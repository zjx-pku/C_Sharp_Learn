using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            Primes primeFrom2To1000 = new Primes(2, 1000);
            foreach (long i in primeFrom2To1000)
                Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}
