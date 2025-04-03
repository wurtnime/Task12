using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0305
{
    public class MatrixSorterr
    {
        public void SortRowsByLastElement(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < rows - 1 - i; j++)
                {
                    if (matrix[j, cols - 1] < matrix[j + 1, cols - 1])
                    {
                        SwapRows(matrix, j, j + 1);
                    }
                }
            }
        }

        private void SwapRows(int[,] matrix, int row1, int row2)
        {
            int cols = matrix.GetLength(1);

            for (int j = 0; j < cols; j++)
            {
                int temp = matrix[row1, j];
                matrix[row1, j] = matrix[row2, j];
                matrix[row2, j] = temp;
            }
        }

        public void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{matrix[i, j],5}");
                }
                Console.WriteLine();
            }
        }
    }
}
