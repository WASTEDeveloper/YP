using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YP_1Lib
{
    /// <summary>
    /// Sum of line 1 + 1/2 + 1/3 + ... + 1/n
    /// </summary>
    public class ProgressivSum
    {
        public int n { get; set; }

        /// <summary>
        /// Constructor for init vars
        /// </summary>
        /// <param name="n">Last number for loop</param>
        public ProgressivSum(int n)
        {
            this.n = n;
        }

        /// <summary>
        /// Get Result
        /// </summary>
        /// <returns>Sum of line (1 + 1/2 + ... + 1/n)</returns>
        public double result()
        {
            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += 1d / i;
            }

            return sum;
        }
    }
}
