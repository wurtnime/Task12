using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0305
{
    public class MatrixAnalyzers
    {
        public (int row, int col) FindElement(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int maxOfMin = int.MinValue;
            int resultRow = -1, resultCol = -1;

            for (int i = 0; i < rows; i++)
            {
                int minInRow = matrix[i, 0];
                int minCol = 0;

                for (int j = 1; j < cols; j++)
                {
                    if (matrix[i, j] < minInRow)
                    {
                        minInRow = matrix[i, j];
                        minCol = j;
                    }
                }

                if (minInRow > maxOfMin)
                {
                    maxOfMin = minInRow;
                    resultRow = i;
                    resultCol = minCol;
                }
            }

            return (resultRow, resultCol);
        }
    }
}
