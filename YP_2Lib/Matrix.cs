using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YP_2Lib
{
    public class Matrix
    {
        private int m { get; set; }
        private int n { get; set; }
        private int[] NumSet { get; set; }
        private int[,] matrix { get; set; }

        public void Start()
        {
            Console.WriteLine("Введите M: ");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите N: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите набор значений: ");
            NumSet = new int[m];
            for (int i = 0; i < NumSet.Length; i++){
                Console.WriteLine($"Введите {i + 1}-e значениe набора: ");
                NumSet[i] = int.Parse(Console.ReadLine());
            }

            InitMatrix();

            Output();
        }

        private void InitMatrix()
        {
            matrix = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = NumSet[i];
                }
            }
        }

        private void Output()
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
