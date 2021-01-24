using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YP_2
{
    public class MatrixGraph
    {
        private int n { get; set; }
        private int m { get; set; }
        private int[] CURRENT_POSSITION = new int[2];
        private int[,] matrix { get; set; }

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
            matrix = new int[n + 1, m + 1];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = -1;
                }
            }

            var rnd = new Random();
            for (int i = 1; i < n - 1; i++)
            {
                for (int j = 1; j < m - 1; j++)
                {
                    matrix[i, j] = rnd.Next(1, 10);
                }
            }
        }

        private void Output()
        {
            for (int i = 1; i < n - 1; i++)
            {
                for (int j = 1; j < m - 1; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        private int Min(int[] NumsArround)
        {
            int min = int.MaxValue;
            for (int i = 0; i < NumsArround.Length; i++)
            {
                if (NumsArround[i] != -1 && NumsArround[i] < min)
                {
                    min = NumsArround[i];
                }
            }
            return min;
        }

        private int[] TakeSides()
        {
            int[] SidesArray = new int[4];

            SidesArray[0] = matrix[CURRENT_POSSITION[0] + 1, CURRENT_POSSITION[1]];
            SidesArray[1] = matrix[CURRENT_POSSITION[0], CURRENT_POSSITION[1] - 1];
            SidesArray[2] = matrix[CURRENT_POSSITION[0] - 1, CURRENT_POSSITION[1]];
            SidesArray[3] = matrix[CURRENT_POSSITION[0], CURRENT_POSSITION[1] + 1];

            return SidesArray;
        }

        private void CheckSide(int min)
        {
            if (matrix[CURRENT_POSSITION[0] + 1, CURRENT_POSSITION[1]] != -1 && 
                matrix[CURRENT_POSSITION[0] + 1, CURRENT_POSSITION[1]] == min)
            {
                matrix[CURRENT_POSSITION[0], CURRENT_POSSITION[1]] = -1;
                CURRENT_POSSITION[0]++; // DOWN
            }
            else if (matrix[CURRENT_POSSITION[0], CURRENT_POSSITION[1] - 1] != -1 &&
                matrix[CURRENT_POSSITION[0], CURRENT_POSSITION[1] - 1] == min)
            {
                matrix[CURRENT_POSSITION[0], CURRENT_POSSITION[1]] = -1;
                CURRENT_POSSITION[1]--; // LEFT
            }
            else if (matrix[CURRENT_POSSITION[0] - 1, CURRENT_POSSITION[1]] != -1 &&
                matrix[CURRENT_POSSITION[0] - 1, CURRENT_POSSITION[1]] == min)
            {
                matrix[CURRENT_POSSITION[0], CURRENT_POSSITION[1]] = -1;
                CURRENT_POSSITION[0]--; // TOP
            }
            else if (matrix[CURRENT_POSSITION[0], CURRENT_POSSITION[1] + 1] != -1 &&
                matrix[CURRENT_POSSITION[0], CURRENT_POSSITION[1] - 1] == min)
            {
                matrix[CURRENT_POSSITION[0], CURRENT_POSSITION[1]] = -1;
                CURRENT_POSSITION[1]++; // RIGHT
            }
        }

        private void Way()
        {
            Console.WriteLine("Введите сумму: ");
            int sum = int.Parse(Console.ReadLine());

            Console.Write("Путь: ");

            CURRENT_POSSITION[0] = 1; //i
            CURRENT_POSSITION[1] = m - 2; //j

            Console.Write(matrix[CURRENT_POSSITION[0], CURRENT_POSSITION[1]] + " ");
            while (sum > 0)
            {
                CheckSide(Min(TakeSides()));
                Console.Write(matrix[CURRENT_POSSITION[0], CURRENT_POSSITION[1]] + " ");
                sum -= matrix[CURRENT_POSSITION[0], CURRENT_POSSITION[1]];
            }

            Console.WriteLine($"Сумма: {sum}");
        }
    }
}
