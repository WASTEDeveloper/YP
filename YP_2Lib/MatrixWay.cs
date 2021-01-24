using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YP_2Lib
{
    public class MatrixWay
    {
        private int n { get; set; }
        private int m { get; set; }
        private int[,] matrix { get; set; }
        private int[] pos = new int[2];

        public void Start()
        {
            InitMatrix();

            Output();

            Way();
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
                    matrix[i, j] = rnd.Next(1, 10);
                }
            }
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

        private void Way()
        {
            Console.WriteLine("Введите в какую точку вы хотите идти: ");
            int k = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            if (k == 0 || l == 0)
            {
                Console.WriteLine("Пути нет!");
                return;
            }

            Console.WriteLine(matrix[k - 1, l - 1]);

            Console.Write("Путь: ");
            Console.Write(matrix[1, 1] + " ");
            pos[0] = 1;
            pos[1] = 1;
            int CurrentPoint = 1;

            while (pos[0] != k && pos[1] != l && CurrentPoint != matrix[k - 1, l - 1])
            {
                if (pos[0] == k - 1)
                {
                    Console.Write(matrix[pos[0], pos[1] + 1] + " ");
                    CurrentPoint = matrix[pos[0], pos[1] + 1];
                    pos[1]++;
                }
                else if (pos[1] == l - 1)
                {
                    Console.Write(matrix[pos[0] + 1, pos[1]] + " ");
                    CurrentPoint = matrix[pos[0] + 1, pos[1]];
                    pos[0]++;
                }
                else
                {
                    if (matrix[pos[0], pos[1] + 1] <= matrix[pos[0] + 1, pos[1]])
                    {
                        Console.Write(matrix[pos[0], pos[1] + 1] + " ");
                        CurrentPoint = matrix[pos[0], pos[1] + 1];
                        pos[1]++;
                    }
                    else
                    {
                        Console.Write(matrix[pos[0] + 1, pos[1]] + " ");
                        CurrentPoint = matrix[pos[0] + 1, pos[1]];
                        pos[0]++;
                    }
                }
            }
        }
    }
}
