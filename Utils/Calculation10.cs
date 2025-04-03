using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0305
{
    public class MatrixAnalyzer
    {
        public int CountMonotonicColumns(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int count = 0;

            for (int j = 0; j < cols; j++)
            {
                bool isMonotonic = true;
                for (int i = 1; i < rows; i++)
                {
                    if (matrix[i, j] >= matrix[i - 1, j])
                    {
                        isMonotonic = false;
                        break;
                    }
                }

                if (isMonotonic)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
