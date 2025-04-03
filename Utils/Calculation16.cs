using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0305
{
    public class MatrixChecker
    {
        public bool IsSymmetric(int[,] matrix)
        {
            int n = matrix.GetLength(0);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] != matrix[j, i])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
