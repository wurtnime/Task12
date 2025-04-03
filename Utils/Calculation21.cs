using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0305
{
    public class MatrixSortere
    {
        public void SortBySecondaryDiagonal(int[,] matrix)
        {
            int n = matrix.GetLength(0);

            // Собираем элементы побочной диагонали
            int[] diagonal = new int[n];
            for (int i = 0; i < n; i++)
            {
                diagonal[i] = matrix[i, n - 1 - i];
            }

            // Сортируем элементы побочной диагонали
            Array.Sort(diagonal);

            // Заменяем элементы побочной диагонали на отсортированные
            for (int i = 0; i < n; i++)
            {
                matrix[i, n - 1 - i] = diagonal[i];
            }
        }

        public void PrintMatrix(int[,] matrix)
        {
            int n = matrix.GetLength(0);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{matrix[i, j],3}");
                }
                Console.WriteLine();
            }
        }
    }
}
