using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YP_1Lib
{
    /// <summary>
    /// Permutetion of numeralf from number
    /// </summary>
    public class NumeralPermutation
    {
        /// <summary>
        /// number variable
        /// </summary>
        public int num { get; set; }
        /// <summary>
        /// array of numbers
        /// </summary>
        public int[] arrReal;

        /// <summary>
        /// Constructor for init vars
        /// </summary>
        /// <param name="num">number for permutation</param>
        public NumeralPermutation(int num)
        {
            this.num = num;

            char[] temp = num.ToString().ToCharArray();
            arrReal = new int[temp.Length];

            for (int i = 0; i < temp.Length; i++)
            {
                arrReal[i] = (int)temp[i] - 48;
            }
        }

        /// <summary>
        /// swap 2 numbers
        /// </summary>
        /// <param name="a">array of numbers</param>
        /// <param name="i">number 1</param>
        /// <param name="j">number 2</param>
        public void swap(int[] a, int i, int j)
        {
            int s = a[i];
            a[i] = a[j];
            a[j] = s;
        }

        /// <summary>
        /// check to swap func
        /// </summary>
        /// <param name="a">array of numbers</param>
        /// <param name="n">count of elemnts</param>
        /// <returns>true/false - it`s a bool for check chanec to swap</returns>
        public bool NextSet(int[] a, int n)
        {
            int j = n - 2;
            while (j != -1 && a[j] >= a[j + 1]) 
                j--;
            if (j == -1)
                return false;
            int k = n - 1;
            while (a[j] >= a[k]) k--;
            swap(a, j, k);
            int l = j + 1, r = n - 1; 
            while (l < r)
                swap(a, l++, r--);
            return true;
        }
        /// <summary>
        /// print array
        /// </summary>
        /// <param name="a">array of numbers</param>
        /// <param name="n">count numbers</param>
        public void Print(int[] a, int n)
        { 
            for (int i = 0; i < n; i++)
                Console.Write(arrReal[a[i]] + " ");
            Console.WriteLine();
        }

        /// <summary>
        /// Permutations of number
        /// </summary>
        public void result()
        {
            int[] arr = new int[num.ToString().ToCharArray().Length];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }

            char[] temp = num.ToString().ToCharArray();
            int[] arrReal = new int[temp.Length];

            for (int i = 0; i < temp.Length; i++)
            {
                arrReal[i] = (int)temp[i] - 48;
            }

            Print(arr, arr.Length);
            while (NextSet(arr, arr.Length))
                Print(arr, arr.Length);
        }
    }
}
