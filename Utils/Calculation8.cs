using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0305
{
    public class MatrixProcessorr
    {
        public int FindMinSumRow(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int minSum = int.MaxValue;
            int minSumRow = -1;

            for (int i = 0; i < rows; i++)
            {
                int rowSum = GetRowSum(matrix, i);
                if (rowSum < minSum)
                {
                    minSum = rowSum;
                    minSumRow = i;
                }
            }

            return minSumRow;
        }

        public int GetRowSum(int[,] matrix, int row)
        {
            int cols = matrix.GetLength(1);
            int sum = 0;

            for (int j = 0; j < cols; j++)
            {
                sum += matrix[row, j];
            }

            return sum;
        }

        public void MultiplyMatrixByValue(int[,] matrix, int value)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] *= value;
                }
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
