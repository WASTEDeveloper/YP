using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kamilla
{
    class Program
    {
        static void Main(string[] args)
        {
            var z2 = new Z2();
            z2.Start();

            var z3 = new Z3();
            z3.Start();

            Console.ReadLine();
        }
    }
}
