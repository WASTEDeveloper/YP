using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YP_7
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringer = new Stringer();

            stringer.regFirstLast();
            stringer.strPovt();
            stringer.Encrypt();
            stringer.Email();
            stringer.Year();

            Console.ReadLine();
        }
    }
}
