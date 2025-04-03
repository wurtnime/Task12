using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0305
{
    public class MatrixAnalyzerryr
    {
        public int CountSimilarRows(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            if (rows == 0 || cols == 0)
                return 0;

           
            var firstRowSet = new HashSet<int>();
            for (int j = 0; j < cols; j++)
            {
                firstRowSet.Add(matrix[0, j]);
            }

            int count = 0;

            
            for (int i = 0; i < rows; i++)
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
