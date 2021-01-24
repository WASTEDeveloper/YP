using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YP_1Lib
{
    /// <summary>
    /// Method return result of Mathematic Function
    /// </summary>
    public class MathFunction
    {        
        public double x { get; set; }
        public double y { get; set; }
        public double z { get; set; }
        public double u { get; set; }

        /// <summary>
        /// Constructor for variables
        /// </summary>
        /// <param name="x">Var for function</param>
        /// <param name="y">Var for function</param>
        /// <param name="z">Var for function</param>
        public MathFunction(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        /// <summary>
        /// Result
        /// </summary>
        /// <returns>return result of Mathematic Function</returns>
        public double result()
        {
            return ((Math.Pow((8 + Math.Pow(Math.Abs(x - y), 2) + 1), 1/3d)) / (Math.Pow(x, 2) + Math.Pow(y, 2) + 2)) - Math.Pow(Math.E, Math.Abs(x - y)) * Math.Pow(Math.Pow(Math.Tan(z), 2) + 1, x);
        }
    }
}
