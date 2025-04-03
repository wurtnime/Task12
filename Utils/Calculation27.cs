using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0305.Utils
{
    public class MatrixAnalyze
    {
        public int CountSimilarRows(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            var firstRowSet = new HashSet<int>();
            for (int j = 0; j < cols; j++)
            {
                firstRowSet.Add(matrix[0, j]);
            }

            int count = 0;

            for (int i = 1; i < rows; i++)
            {
                var currentRowSet = new HashSet<int>();
                for (int j = 0; j < cols; j++)
                {
                    currentRowSet.Add(matrix[i, j]);
                }

                if (currentRowSet.SetEquals(firstRowSet))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
