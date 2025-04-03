using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0305
{
    public class MatrixAnalyzerу
    {
        public int FindMaxInOrderedColumns(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int maxElement = 0;

            for (int j = 0; j < cols; j++)
            {
                bool isAscending = true;
                bool isDescending = true;

                for (int i = 1; i < rows; i++)
                {
                    if (matrix[i, j] <= matrix[i - 1, j])
                    {
                        isAscending = false;
                    }
                    if (matrix[i, j] >= matrix[i - 1, j])
                    {
                        isDescending = false;
                    }
                }

                if (isAscending || isDescending)
                {
                    for (int i = 0; i < rows; i++)
                    {
                        if (matrix[i, j] > maxElement)
                        {
                            maxElement = matrix[i, j];
                        }
                    }
                }
            }

            return maxElement;
        }
    }
}
