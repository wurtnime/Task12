using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0305
{
    public class ArrayFille
    {
        public int[,] FillArraySpiral(int n)
        {
            int size = 2 * n + 1;
            int[,] array = new int[size, size];
            int value = 0;
            int x = n, y = n;
            int step = 1;

            array[x, y] = value++;

            while (step <= n)
            {
                for (int i = 0; i < step; i++) array[--x, y] = value++;
                for (int i = 0; i < step; i++) array[x, ++y] = value++;
                step++;
                for (int i = 0; i < step; i++) array[++x, y] = value++;
                for (int i = 0; i < step; i++) array[x, --y] = value++;
                step++;
            }

            return array;
        }

        public void PrintArray(int[,] array)
        {
            int size = array.GetLength(0);

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write($"{array[i, j],3}");
                }
                Console.WriteLine();
            }
        }
    }
}
