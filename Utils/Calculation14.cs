using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0305
{
    public class MatrixProcesso
    {
        public void MoveMinElementsToFirstColumn(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                int minCol = 0;
                for (int j = 1; j < cols; j++)
                {
                    if (matrix[i, j] < matrix[i, minCol])
                    {
                        minCol = j;
                    }
                }

                
                int temp = matrix[i, 0];
                matrix[i, 0] = matrix[i, minCol];
                matrix[i, minCol] = temp;
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
