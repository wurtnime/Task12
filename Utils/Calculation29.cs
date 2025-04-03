using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0305
{
    public class MatrixAnalyzerryy
    {
        public int CountSimilarColumns(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            var lastColumnSet = new HashSet<int>();
            for (int i = 0; i < rows; i++)
            {
                lastColumnSet.Add(matrix[i, cols - 1]);
            }

            int count = 0;

            for (int j = 0; j < cols - 1; j++)
            {
                var currentColumnSet = new HashSet<int>();
                for (int i = 0; i < rows; i++)
                {
                    currentColumnSet.Add(matrix[i, j]);
                }

                if (currentColumnSet.SetEquals(lastColumnSet))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
