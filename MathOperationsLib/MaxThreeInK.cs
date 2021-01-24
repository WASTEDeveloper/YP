using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YP_1Lib
{
    /// <summary>
    /// Maximum 3 in power K low thenn N
    /// </summary>
    public class MaxThreeInK
    {
        public int n { get; set; }

        /// <summary>
        /// Constructor for init Vars
        /// </summary>
        /// <param name="n">Max element</param>
        public MaxThreeInK(int n)
        {
            this.n = n;
        }

        /// <summary>
        /// Get max power of 3 that lower then N
        /// </summary>
        /// <returns>Power of 3</returns>
        public int result()
        {
            int k = 0;

            while (Math.Pow(3, k) < n)
            {
                k++;
            }

            return k - 1;
        }
    }
}
