using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0305
{
    public class ArrayFilleryd
    {
        public int[,] FillArrayDiagonal(int n, int m)
        {
            int[,] array = new int[n, m];
            int value = 0;

            for (int d = 0; d < n + m - 1; d++)
            {
                int i = Math.Max(0, d - m + 1);
                int j = Math.Min(d, m - 1);

                while (i < n && j >= 0)
                {
                    array[i, j] = value++;
                    i++;
                    j--;
                }
            }

            return array;
        }

        public void PrintArraye(int[,] array)
        {
            int n = array.GetLength(0);
            int m = array.GetLength(1);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{array[i, j],3}");
                }
                Console.WriteLine();
            }
        }
    }
}
