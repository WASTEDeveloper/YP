using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YP_1Lib
{
    /// <summary>
    /// Find all perfect numbers of range [a, b]
    /// </summary>
    public class PerfectNumbers
    {
        public int a { get; set; }
        public int b { get; set; }

        /// <summary>
        /// Constructor for init vars
        /// </summary>
        /// <param name="a">min value of range</param>
        /// <param name="b">max value of range</param>
        public PerfectNumbers(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        /// <summary>
        /// Checked number on perfect
        /// </summary>
        /// <param name="num">Number for check on perfect</param>
        /// <returns>true/false - perfect or not</returns>
        public bool CheckNumber(int num)
        {
            int sum = 1;
            for (int i = 2; i < num / 2 + 1; i++)
            {
                if (num % i == 0)
                    sum += i;
            }
            return (sum == num);                                               
        }

        /// <summary>
        /// all perfect numbers of range
        /// </summary>
        public void result()
        {
            for (int i = a; i <= b; i++)
            {
                if (CheckNumber(i))
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
