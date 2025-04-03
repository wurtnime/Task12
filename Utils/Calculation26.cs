using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0305
{
    public class MatrixProcessor
    {
        public void RearrangeColumns(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] == 1)
                    {
                        
                        for (int k = 0; k < rows; k++)
                        {
                            int temp = matrix[k, j];
                            matrix[k, j] = matrix[k, 0];
                            matrix[k, 0] = temp;
                        }
                        break;
                    }
                }
            }
        }

        public void PrintMatrixx(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{matrix[i, j],3}");
                }
                Console.WriteLine();
            }
        }
    }
}
