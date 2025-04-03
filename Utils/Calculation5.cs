using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0305
{
    public class MatrixSorter
    {
        public void BubbleSort(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[] flatArray = new int[rows * cols];

            
            int index = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    flatArray[index++] = matrix[i, j];
                }
            }

            
            for (int i = 0; i < flatArray.Length - 1; i++)
            {
                for (int j = 0; j < flatArray.Length - 1 - i; j++)
                {
                    if (flatArray[j] > flatArray[j + 1])
                    {
                        int temp = flatArray[j];
                        flatArray[j] = flatArray[j + 1];
                        flatArray[j + 1] = temp;
                    }
                }
            }

           
            index = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = flatArray[index++];
                }
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
                    Console.Write($"{matrix[i, j],3}");
                }
                Console.WriteLine();
            }
        }
    }
}
