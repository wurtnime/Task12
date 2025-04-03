using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0305
{
    public class ArrayFillerr
    {
        public int[,] FillArray(int n, int m)
        {
            int[,] array = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                array[i, 0] = 1;
            }

            for (int j = 0; j < m; j++)
            {
                array[0, j] = 1;
            }

            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < m; j++)
                {
                    array[i, j] = array[i - 1, j] + array[i, j - 1];
                }
            }

            return array;
        }

        public void PrintArray(int[,] array)
        {
            int n = array.GetLength(0);
            int m = array.GetLength(1);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{array[i, j],6}");
                }
                Console.WriteLine();
            }
        }
    }
}
