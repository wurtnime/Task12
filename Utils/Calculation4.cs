using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0312
{
    public class Calculation4
    {
        public int[] GetElementsBelowDiagonal(int[,] matrix)
        {
            int size = matrix.GetLength(0);
            int[] result = new int[size * (size - 1) / 2];
            int index = 0;

            for (int i = 1; i < size; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    result[index++] = matrix[i, j];
                }
            }

            return result;
        }

        public void PrintArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}
