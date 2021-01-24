using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YP_2Lib
{
    public class MatrixFound
    {
        private int n { get; set; }
        private int m { get; set; }
        private int[,] matrix { get; set; }

        public void Start()
        {
            InitMatrix();

            Output();

            Console.WriteLine(MatrixAvgValue());

            Difference();
        }

        private void InitMatrix()
        {
            Console.WriteLine("Введите количество строк: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов: ");
            m = int.Parse(Console.ReadLine());
            matrix = new int[n, m];

            var rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = rnd.Next(0, 10);
                }
            }
        }

        private int MatrixAvgValue()
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    sum += matrix[i, j];
                }
            }
            return sum / (n * m);
        }

        private void Output()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        private void Difference()
        {
            int[,] differencesMatrix = new int[n, m];
            int avg = MatrixAvgValue();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    differencesMatrix[i, j] = Math.Abs(avg - matrix[i, j]);
                }
                Console.WriteLine();
            }

            MinDifference(differencesMatrix);
        }

        private void MinDifference(int[,] differences)
        {
            int min = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (min > differences[i, j])
                        min = differences[i, j];
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (differences[i, j] == min)
                        Console.WriteLine($"Минмальная разница между средним и элементом [{i}, {j}]: {matrix[i, j]} = {min}");
                }
            }
        }
    }
}
