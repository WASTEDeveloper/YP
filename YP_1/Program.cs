using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YP_1Lib;

namespace YP_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var func = new MathFunction(-4.5, 0.75 * Math.Pow(10, -4), 0.845 * Math.Pow(10, 2));
            Console.WriteLine(func.result());

            var sum = new ProgressivSum(4);
            Console.WriteLine(sum.result());

            var power = new MaxThreeInK(90);
            Console.WriteLine(power.result());

            var perfect = new PerfectNumbers(0, 1000);
            perfect.result();

            Console.WriteLine();

            var permutation = new NumeralPermutation(6583);
            permutation.result();

            Console.ReadLine();
        }
    }
}
