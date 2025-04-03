using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0305
{
    public class MatrixProcessored
    {
        public void ReflectOverSecondaryDiagonal(int[,] matrix)
        {
            int size = matrix.GetLength(0);

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size - i - 1; j++)
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[size - j - 1, size - i - 1];
                    matrix[size - j - 1, size - i - 1] = temp;
                }
            }
        }

        public void PrintMatrix(int[,] matrix)
        {
            int size = matrix.GetLength(0);

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write($"{matrix[i, j],5}");
                }
                Console.WriteLine();
            }
        }
    }
}
