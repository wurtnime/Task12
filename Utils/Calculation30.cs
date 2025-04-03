using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0305
{
    public class ArrayFil
    {
        public int[,] CreatePatternArray()
        {
            int[,] array = new int[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        array[i, j] = 1;
                    }
                    else
                    {
                        array[i, j] = 0;
                    }
                }
            }

            return array;
        }

        public void PrintArray(int[,] array)
        {
            int n = array.GetLength(0);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{array[i, j],3}");
                }
                Console.WriteLine();
            }
        }
    }
}