using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YP_2Lib
{
    public class MatrixAdd
    {
        private int n { get; set; }
        private int[,] matrix { get; set; }

        public void Start()
        {
            InitMatrix();

            Output();

            Add();
        }

        private void InitMatrix()
        {
            Console.WriteLine("Введите размерность матрицы: ");
            n = int.Parse(Console.ReadLine());
            matrix = new int[n, n];

            var rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rnd.Next(0, 10);
                }
            }
        }

        private void Add()
        {
            int even = CheckEven();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        matrix[i, j] += even;
                    }
                }
            }

            Console.WriteLine();

            Output();
        }

        private int CheckEven()
        {
            int even = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        even = matrix[i, j];
                        return even;
                    }
                }
            }
            return 0;
        }

        private void Output()
        {
            for (int i = 0; i < n; i++)
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
